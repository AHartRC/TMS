namespace TechnicalMarineSolutions.Interfaces.Mapping.Many
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IManyAppErrorable
	{
		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.AppError" /> Records
		/// </summary>
		ICollection<AppError> Errors
		{
			get;
			set;
		}
	}
}