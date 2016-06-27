namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	#region Library Imports

	#endregion

	public interface IManufacturerable
	{
		/// <summary>
		///     The ID of the <see cref="Manufacturer" /> Record
		/// </summary>
		long ManufacturerId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Manufacturer" /> Record
		/// </summary>
		Manufacturer Manufacturer
		{
			get;
			set;
		}
	}
}