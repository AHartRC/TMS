#region Library Imports

using System.Web.Mvc;
using System.Web.Routing;

#endregion

namespace TechnicalMarineSolutions.Configurations
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute("Default", "{area}/{controller}/{action}/{id}",
							new
							{
								area = "",
								controller = "Home",
								action = "Index",
								id = UrlParameter.Optional
							},
							new[]
							{
								"TechnicalMarineSolutions.Controllers"
							}
				);
		}
	}
}