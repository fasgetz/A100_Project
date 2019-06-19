﻿using A100_AspNetCore.Models.Authentication;
using A100_AspNetCore.Services.API;
using A100_AspNetCore.Services.API._DBService;
using A100_AspNetCore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace A100_AspNetCore.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User { Email = model.Email, UserName = model.Email };
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        //[Authorize(Roles = "user")]
        [AllowAnonymous]
        public string set()
        {
            return "tpli";
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            // Если пользователь авторизован, то перекинь на главную страницу контролелра Home
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                // Находим юзера по емейлу
                var user = await _userManager.FindByEmailAsync(model.Email);

                // Если пользователь не найден, то верни ошибку
                if (user == null)
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                    return View(model);
                }
                    

                // Если пользователь найден, то сбрось куки (Секьюрити стамп) и его токен
                var removed = await UnLoginUser(user);


                // Далее проходим авторизацию
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

                // Если авторизация успешна
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                // Иначе, авторизация не успешна, то выведи это
                ModelState.AddModelError("", "Неправильный логин и (или) пароль");

            }
            return View(model);
        }


        /// <summary>
        /// Метод, который сбрасывает аутентификационные куки, а также токен
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        /// <returns>TRUE, если куки сбросились. False, если произошла ошибка при сбрасывании</returns>
        private async Task<bool> UnLoginUser(User user)
        {
            try
            {
                // Обновляем секретный ключ
                await _userManager.UpdateSecurityStampAsync(user);

                // Ищем токен
                var token = await DbUsers.db.RefreshTokens.FirstOrDefaultAsync(i => i.IdUser == user.Id && i.IsActive == true);
                // Если токен найден, то отключи его
                if (token != null)
                {
                    token.IsActive = false;
                    await DbUsers.db.SaveChangesAsync();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Метож выхода из аккаунта
        /// </summary>
        /// <returns>Редиректит на главную страницу контроллера Home</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            // Удаляем аутентификационные куки и делаем редиректинг на главную страницу 
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
