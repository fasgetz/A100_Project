﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A100_AspNetCore.API.Authentication.Options;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.API;
using A100_AspNetCore.Models.Authentication;
using A100_AspNetCore.Services.API;
using A100_AspNetCore.Services.API.CityService;
using A100_AspNetCore.Services.API.EmployeesService;
using A100_AspNetCore.Services.API.Projects;
using A100_AspNetCore.Services.API.RefreshTokenService;
using A100_AspNetCore.Services.API.SchemeService;
using A100_AspNetCore.Services.API.SpecificationsService;
using A100_AspNetCore.Services.API.VikService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace A100_AspNetCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Подключаем контекст базы данных пользователей
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("aspUsers")));

            // Подключаем базу данных моделей контекста А100
            // Подключаем контекст базы данных пользователей
            services.AddDbContext<ASTIContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ASTI_db")));


            // Конфигурация куки файлов
            //services.ConfigureApplicationCookie(opts => {
            //    opts.Cookie.Name = "My.Cookie.User";
            //});

            // Валидация защиты (Сброс куки тут)
            services.Configure<SecurityStampValidatorOptions>(options =>
            {
                options.ValidationInterval = TimeSpan.FromSeconds(1);
            });

            // JWT токен для авторизации


            services
                .AddAuthentication(x =>
            {                
                x.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;                
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    // укзывает, будет ли валидироваться издатель при валидации токена
                    ValidateIssuer = true,
                    // строка, представляющая издателя
                    ValidIssuer = AuthOptions.ISSUER,

                    // будет ли валидироваться потребитель токена
                    ValidateAudience = true,
                    // установка потребителя токена
                    ValidAudience = AuthOptions.AUDIENCE,
                    // будет ли валидироваться время существования
                    ValidateLifetime = true,
                    LifetimeValidator = AuthOptions.CustomLifetimeValidator, // Валидация времени

                    // установка ключа безопасности
                    IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                    // валидация ключа безопасности
                    ValidateIssuerSigningKey = true,
                };
            });
            // Конец JWT

            // Подключаем идентификацию пользователей по базе данных
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>();

            services.AddSingleton<CounterMiddleWare>();
            services.AddSingleton<TokensService>();
            // Регистрируем сервисы (AddScoped - выделяет память, в случае обращения к сервису, на всю транзакцию)                      
            services.AddScoped<IUserService, UserService>(); // Сервис авторизации
            services.AddScoped<ICityService, CityService>(); // Сервис городов
            services.AddScoped<IProjectsService, ProjectsService>(); // Сервис проектов
            services.AddScoped<IEmployeeService, EmployeeService>(); // Сервис клиентов
            services.AddScoped<ISchemeService, SchemeService>(); // Сервис схемы (карта)
            services.AddScoped<IVikService, VikService>(); // VIK сервис (повреждения
            services.AddScoped<ISpecificationsService, SpecificationsService>(); // Сервис спецификаций


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Login}");
            });
        }
    }

}
