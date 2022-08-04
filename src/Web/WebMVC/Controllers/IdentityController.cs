using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    [AllowAnonymous]
    public class IdentityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Login(IdentityLoginUserViewModel identityLoginUserViewModel)
        {
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, "kaueys@outlook.com"));
            claims.Add(new Claim(ClaimTypes.Email, "kaueys@outlook.com"));
            claims.Add(new Claim(ClaimTypes.Name, $"{"Souza"} {"Kaue"}"));
            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            claimsPrincipal.AddIdentity(identity);
            AuthenticationProperties authenticationProperties = new AuthenticationProperties() { IsPersistent = false, ExpiresUtc = DateTimeOffset.MaxValue };
            await this.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, authenticationProperties);
            
            return RedirectToAction("Dashboard", "Home");
        }
    }
}
