namespace TechnicalMarineSolutions.Configurations
{
	#region Library Imports

	using System.Web.Mvc;

	#endregion

	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}