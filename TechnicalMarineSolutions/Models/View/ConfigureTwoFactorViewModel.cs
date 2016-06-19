namespace TechnicalMarineSolutions.Models.View
{
	#region Library Imports

	using System.Collections.Generic;
	using System.Web.Mvc;

	#endregion

	public class ConfigureTwoFactorViewModel
	{
		public string SelectedProvider
		{
			get;
			set;
		}

		public ICollection<SelectListItem> Providers
		{
			get;
			set;
		}
	}
}