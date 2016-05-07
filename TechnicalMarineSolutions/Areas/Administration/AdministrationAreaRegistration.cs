#region Library Imports

using System.Web.Mvc;

#endregion

namespace TechnicalMarineSolutions.Areas.Administration
{
	public class AdministrationAreaRegistration : AreaRegistration
	{
		public override string AreaName => "Administration";

		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
							 "Administration_default",
							"Administration/{controller}/{action}/{id}",
							new
							{
								area = "Administration",
								controller = "Home",
								action = "Index",
								id = UrlParameter.Optional
							},
							new[]
							{
								"TechnicalMarineSolutions.Areas.Administration.Controllers"
							}
				);
		}
	}
}