#region Library Imports

using System.ComponentModel.DataAnnotations;
using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IUserable
	{
		[MaxLength(128)]
		[Required]
		string UserId
		{
			get;
			set;
		}

		ApplicationUser User
		{
			get;
			set;
		}
	}
}