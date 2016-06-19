namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IVehicleable
	{
		/// <summary>
		///     The ID of the <see cref="Vehicle" /> Record
		/// </summary>
		long? VehicleId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Vehicle" /> Record
		/// </summary>
		Vehicle Vehicle
		{
			get;
			set;
		}
	}
}