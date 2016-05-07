#region Library Imports

using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IPersonalInfoable
	{
		long PersonalInfoId
		{
			get;
			set;
		}

		Person PersonalInformation
		{
			get;
			set;
		}
	}
}