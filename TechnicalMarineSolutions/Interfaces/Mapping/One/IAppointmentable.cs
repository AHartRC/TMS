namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IAppointmentable
	{
		/// <summary>
		///     The ID of the <see cref="Appointment" /> Record
		/// </summary>
		long AppointmentId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Appointment" /> Record
		/// </summary>
		Appointment Appointment
		{
			get;
			set;
		}
	}
}