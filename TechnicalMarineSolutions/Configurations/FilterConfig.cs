#region Library Imports

using System.Web.Mvc;

#endregion

namespace TechnicalMarineSolutions.Configurations
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}