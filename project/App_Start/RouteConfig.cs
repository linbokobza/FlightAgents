using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute(
            //    name: "SignUp",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "SignUp", id = UrlParameter.Optional }
            //);


            routes.MapRoute(
             name: "regis",
             url: "Registration",
             defaults: new { controller = "Home", action = "Registration", id = UrlParameter.Optional }
         );

            routes.MapRoute(
              name: "homeReturn",
              url: "home/searchflight",
              defaults: new { controller = "Home", action = "SearchFlight", id = UrlParameter.Optional }
          );

            routes.MapRoute(
              name: "home",
              url: "",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          );

            routes.MapRoute(
             name: "login",
             url: "home/Login",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
         );

          routes.MapRoute(
            name: "booking",
            url: "home/booking",
            defaults: new { controller = "Home", action = "Booking", id = UrlParameter.Optional }
);
            routes.MapRoute(
          name: "bk",
          url: "booking",
          defaults: new { controller = "Home", action = "Booking" }
);

            routes.MapRoute(
                     name: "b",
                     url: "booking",
                     defaults: new { controller = "Home", action = "Booking", id = UrlParameter.Optional }
         );
            routes.MapRoute(
               name: "search",
               url: "searchflight",
               defaults: new { controller = "Home", action = "SearchFlight", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "UserRegister",
               url: "Home/UserRegister",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
