using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelmos.EF;
using travelmos.EntityModels;
using travelmos.ViewModels;
using Microsoft.AspNetCore.Http;
using travelmos.Web.Helper;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace travelmos.Controllers
{
    public class LoginController: Controller
    {
        private ApplicationContext _db;

        public LoginController(ApplicationContext context)
        {
            _db = context;
        }

        [HttpPost]
        public string Index(UserLoginVM model)
        {
            User user = _db.User.Where(x => x.Username == model.Username && x.Password == model.Password).FirstOrDefault();
            if (user != null)
            {
                HttpContext.SetLoggedUser(model);
                return "success";
            }
            return "failure";
        }

        public IActionResult Logout()
        {
            HttpContext.SetLoggedUser(null);

            return Redirect("/");
        }



        public IActionResult SignUp(int RegUserType = 1)
        {
            SignUpUserVM VM = new SignUpUserVM();
            if (RegUserType == 1)
                VM.IsTourist = true;
            else if (RegUserType == 2)
                VM.IsGuide = true;

            LoadDropdowns(VM);

            return View(VM);
        }

        private void LoadDropdowns(SignUpUserVM VM)
        {
            VM.Languages = _db.Language.Select(
                x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.LanguageId.ToString()
                }
                )
                .ToList();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpUserVM model)
        {
            User user1 = _db.User.Where(x => x.Username == model.Username).FirstOrDefault();
            User user2 = _db.User.Where(x => x.Email == model.Email).FirstOrDefault();

            LoadDropdowns(model);

            if (model.IsGuide == false && model.IsTourist == false)
            {
                TempData["error"] = "User type is required!";
                return View(model);
            }
            if (user1 != null)
            {
                TempData["error"] = "Username is already taken!";
                return View(model);
            }
            if (user2 != null)
            {
                TempData["error"] = "Email is already taken!";
                return View(model);
            }

            Guide guide;
            Tourist tourist;

            UserUserType uut = new UserUserType();

            if(model.IsGuide)
            {
                guide = new Guide
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PrimaryLanguageId = model.PrimaryLanguageId
                };
                _db.Guide.Add(guide);

                uut.GuideId = guide.GuideId;
            }
            else if(model.IsTourist)
            {

                tourist = new Tourist
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PrimaryLanguageId = model.PrimaryLanguageId,
                };
                _db.Tourist.Add(tourist);

                uut.TouristId = tourist.TouristId;
            }

            _db.UserUserType.Add(uut);

            User newUser = new User
            {
                Username = model.Username,
                Email = model.Email,
                Password = model.Password,
                UserUserTypeId = uut.UserUserTypeId
            };

            _db.User.Add(newUser);

            _db.SaveChanges();


            UserLoginVM LoginVM = new UserLoginVM
            {
                Username = model.Username,
                Password = model.Password,
                UserId = newUser.UserId
            };

            HttpContext.SetLoggedUser(LoginVM);


            return RedirectToAction("Index", "Home");
        }

    }
}
