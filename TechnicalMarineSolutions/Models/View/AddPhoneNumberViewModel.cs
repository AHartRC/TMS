#region Library Imports

using System.ComponentModel.DataAnnotations;

#endregion

namespace TechnicalMarineSolutions.Models.View
{
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