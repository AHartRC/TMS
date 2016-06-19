namespace TechnicalMarineSolutions.Interfaces.Mapping.Many
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IManyAppErrorable
	{
		ICollection<AppError> Errors
		{
			get;
			set;
		}
	}
}