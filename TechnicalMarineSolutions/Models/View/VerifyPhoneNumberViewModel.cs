namespace TechnicalMarineSolutions.Models.View
{
	#region Library Imports

	using System.ComponentModel.DataAnnotations;

	#endregion

	public class VerifyPhoneNumberViewModel
	{
		[Required]
		[Display(Name = "Code")]
		public string Code
		{
			get;
			set;
		}

		[Required]
		[Phone]
		[Display(Name = "Phone Number")]
		public string PhoneNumber
		{
			get;
			set;
		}
	}
}