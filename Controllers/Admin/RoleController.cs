using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication11.Controllers.Admin
{
     
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _manager;
        public RoleController(RoleManager<IdentityRole> roleManager) 
        {
            _manager = roleManager;

        }
        public IActionResult RoleIndex()
        {
            var role = _manager.Roles;
            return View(role);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(IdentityRole role)
        {
            if(!_manager.RoleExistsAsync(role.Name).GetAwaiter().GetResult()) 
            {
                _manager.CreateAsync(new IdentityRole(role.Name)).GetAwaiter().GetResult();
            }
            return RedirectToAction("RoleIndex");
        }

    }
}
