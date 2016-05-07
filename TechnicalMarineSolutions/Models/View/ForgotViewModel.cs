#region Library Imports

using System.ComponentModel.DataAnnotations;

#endregion

namespace TechnicalMarineSolutions.Models.View
{
	public class ForgotViewModel
	{
		[Required]
		[Display(Name = "Email")]
		public string Email
		{
			get;
			set;
		}
	}
}