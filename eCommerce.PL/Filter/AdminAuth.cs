using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.PL.Filter
{
    public class AdminAuth : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["AdminUser"] == null)
            {
                filterContext.Result = new RedirectResult("/Login/Login");
            }
            else
            {
                User user = filterContext.HttpContext.Session["AdminUser"] as User;
            }
        }
    }
}