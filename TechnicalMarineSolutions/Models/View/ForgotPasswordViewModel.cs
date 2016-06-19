namespace TechnicalMarineSolutions.Models.View
{
	#region Library Imports

	using System.ComponentModel.DataAnnotations;

	#endregion

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