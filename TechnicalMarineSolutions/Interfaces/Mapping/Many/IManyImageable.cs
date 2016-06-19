namespace TechnicalMarineSolutions.Interfaces.Mapping.Many
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IManyImageable
	{
		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Image" /> Records
		/// </summary>
		ICollection<Image> Images
		{
			get;
			set;
		}
	}
}