using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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



        [Authorize(Roles = "admin")]
        public async Task<IActionResult> ModifyRole()
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
        public async Task<IActionResult> ModifyRole(UserWithRoleViewModel model)
        {
            ViewData["Title"] = "Modify-Role";

            if (ModelState.IsValid)
            {
                if (await _auth.ModifyRoleAsync(model.UserId, model.RoleName))
                {
                    TempData["SuccessMessage"] = "Användaren har uppdaterat";
                    return RedirectToAction("index", "List");
                }
                else
                    ModelState.AddModelError("", "Det gick inte att ändra användarroll");
                return View(model);

            }
            return View(model);
        }



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

                ModelState.AddModelError("", "e-post har finns redan");
            }

            return View(model);
        }
   
    }

}
