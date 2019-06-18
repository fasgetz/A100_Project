using A100_AspNetCore.Models.Authentication;
using A100_AspNetCore.Services.API;
using A100_AspNetCore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        private readonly CounterMiddleWare md;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, CounterMiddleWare md)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.md = md;
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
            return md.GetValue.ToString();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
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
                    

                // Если пользователь найден, то сбрось куки (Секьюрити стамп)
                var removed = await UnLoginUser(user);

                // Далее проходим авторизацию
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

                // Если авторизация успешна
                if (result.Succeeded)
                {
                    // проверяем, принадлежит ли URL приложению
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

                // Иначе, авторизация не успешна, то выведи это
                ModelState.AddModelError("", "Неправильный логин и (или) пароль");

            }
            return View(model);
        }


        /// <summary>
        /// Метод, который сбрасывает аутентификационные куки
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        /// <returns>TRUE, если куки сбросились. False, если произошла ошибка при сбрасывании</returns>
        private async Task<bool> UnLoginUser(User user)
        {
            try
            {
                // Обновляем секретный ключ
                await _userManager.UpdateSecurityStampAsync(user);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            // Удаляем аутентификационные куки и делаем редирект на главную сраницу
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
