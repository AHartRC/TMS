namespace TechnicalMarineSolutions.Models.View
{
	#region Library Imports

	using System.ComponentModel.DataAnnotations;

	#endregion

	public class AddPhoneNumberViewModel
	{
		[Required]
		[Phone]
		[Display(Name = "Phone Number")]
		public string Number
		{
			get;
			set;
		}
	}
}