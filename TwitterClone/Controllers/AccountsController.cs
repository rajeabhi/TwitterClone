using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using TwitterClone.Models;
using TwitterClone.ModelsApp_Code;

namespace TwitterClone.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Person person)
        {

            using (var context = new TwitterDbContext())
            {
                bool isValid = context.Person.Any(x => x.user_id == person.user_id && x.password == person.password);

                if (isValid)
                {
                    var p= context.Person.FirstOrDefault(x => x.user_id == person.user_id && x.password == person.password);
                    FormsAuthentication.SetAuthCookie(person.user_id, false);
                    return RedirectToAction("Index", "Home", p);
                }

                ModelState.AddModelError("", "Invalid Used details");
            }
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Person model)
        {
            using (var context = new TwitterDbContext())
            {
                context.Person.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("login");
        }
        [HttpPost]
        public ActionResult Index(Person model)
        {
            if (model.user_id == "admin" && model.password == "admin")
            {
                FormsAuthentication.SetAuthCookie(model.user_id, false);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Accounts");

        }
    }
}