using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using travelmos;
using travelmos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Microsoft.Extensions.DependencyInjection;
using travelmos.EF;
using travelmos.ViewModels;
using travelmos.Helper;
using travelmos.EntityModels;

namespace travelmos.Web.Helper
{
    public static class Authentification
    {
        private const string LoggedUser = "logged_user";

        public static void SetLoggedUser(this HttpContext context, UserLoginVM user)
        {
            context.Session.Set(LoggedUser, user);
        }

        public static UserLoginVM GetLoggedUser(this HttpContext context)
        {
            ApplicationContext _db = context.RequestServices.GetService<ApplicationContext>();
            return context.Session.Get<UserLoginVM>(LoggedUser);
        }

    }
}