using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserIdentity.Identity;

namespace UserIdentity.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        public AdminController()
        {
            userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new IdentityDataContext()));

        }
        // GET: Admin
        public ActionResult Index()
        {
            //bütün kullanıcı bilgileri action metodundan view üzerine tasıdık
            return View(userManager.Users);
        }
    }
}