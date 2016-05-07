#region Library Imports

using System.Collections.Generic;
using System.Web.Mvc;

#endregion

namespace TechnicalMarineSolutions.Models.View
{
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