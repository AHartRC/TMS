namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class VehicleMap : EntityTypeConfiguration<Vehicle>
	{
		public VehicleMap()
		{
			ToTable("Vehicle", "Asset");

			//MapToStoredProcedures();
		}
	}
}