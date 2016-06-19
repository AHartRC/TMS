namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class AppointmentMap : EntityTypeConfiguration<Appointment>
	{
		public AppointmentMap()
		{
			ToTable("Appointment", "Schedule");

			MapToStoredProcedures();
		}
	}
}