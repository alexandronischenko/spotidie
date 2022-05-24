using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spotidie.DAL.EF;
using Spotidie.Models;
using Owin;
using Spotidie.Models.Auth;
using DbContext = System.Data.Entity.DbContext;
using IdentityUser = Microsoft.AspNet.Identity.EntityFramework.IdentityUser;

namespace Spotidie.Controllers.Authentication;

[Authorize]
public class AuthenticationController : Controller
{
    readonly SpotidieContext db;
    readonly IConfiguration _configuration;
    private readonly Microsoft.AspNet.Identity.UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AuthenticationController(Microsoft.AspNet.Identity.UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public AuthenticationController() : this(new Microsoft.AspNet.Identity.UserManager<IdentityUser>(new UserStore<IdentityUser>(new DbContext())))
    {
    }

    [HttpGet]
    public IActionResult Login()
    {
        if (Request.Cookies["token"] != null)
            return RedirectToAction("Index", "Home");
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = 
                await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Privacy", "Home");
                }
                return RedirectToAction("Login", "Authentication");
            }
            else
            {
                ModelState.AddModelError("", "Неправильный логин и (или) пароль");
            }
        }

        return Ok();
    }

    [HttpGet]
    public IActionResult Register()
    {
        if (Request.Cookies["token"] != null)
            return RedirectToAction("Index", "Home");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = new ApplicationUser() {Email = model.Email, UserName = model.Email};

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error);
                }
            }
        }

        return Ok();
    }

// POST: /Account/LogOff
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult LogOff()
    {
        SignOut();
        return RedirectToAction("Index", "Home");
    }
}