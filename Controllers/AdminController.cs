﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApp.Services;
using WebApp.ViewModels;
using WebApp.ViewModels.AccountViewModel;

namespace WebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly AuthService _auth;

        public AdminController(AuthService auth)
        {
            _auth = auth;
        }

        //--------------------------------------------------------------------------------------

        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Admin";
            return View();
        }

        [Authorize(Roles = "admin")]
        public IActionResult List()
        {
            ViewData["Title"] = "User-List";
            return View();
        }

        //--------------------------------------------------------------------------------------


        [Authorize(Roles = "admin")]
        public async Task<IActionResult> ChangeRole()
        {
            var viewModel = new UserWithRoleViewModel
            {
                Title = "Modify-Role",
                UserModels = await _auth.GetAllUserModelAsync(),
                Roles = await _auth.GetRolesAsync()
            };

            ViewData["Title"] = viewModel.Title;
            return View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> ChangeRole(UserWithRoleViewModel model)
        {
            ViewData["Title"] = "Modify-Role";

            if (ModelState.IsValid)
            {
                if (await _auth.ChangeRoleAsync(model.UserId, model.RoleName))
                {
                    TempData["SuccessMessage"] = "The user was updated successfully!";
                    return RedirectToAction("index", "List");
                }
                else
                    ModelState.AddModelError("", "Something went wrong, no changes have been made!");
                return View(model);


            }
            ModelState.AddModelError("", "Failed to change user role.");
            return View(model);
        }

        //--------------------------------------------------------------------------------------


        [Authorize(Roles = "admin")]
        public IActionResult Register()
        {
            ViewData["Title"] = "Register-User";
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Register(RegisterAccountViewModel model)
        {
            ViewData["Title"] = "Register";

            if (ModelState.IsValid)
            {
                if (await _auth.RegisterAsync(model))
                    return RedirectToAction("list", "admin");

                ModelState.AddModelError("", "A user with that e-mail already exists.");
            }

            return View(model);
        }
        //-----------------------------------------------------------------------------------------


 
    }

 
}
