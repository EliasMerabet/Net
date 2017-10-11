public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "JS",
                "JS/code={code}",
                new
                {
                    Controller = "Home",
                    Action = "Selected",
                    code = 0
                }, new {code = @"\d{1,2}" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
