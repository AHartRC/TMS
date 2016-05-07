#region Library Imports

using System.ComponentModel.DataAnnotations;

#endregion

namespace TechnicalMarineSolutions.Models.View
{
	public class ForgotPasswordViewModel
	{
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email
		{
			get;
			set;
		}
	}
}