namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class InventoryMap : EntityTypeConfiguration<Inventory>
	{
		public InventoryMap()
		{
			ToTable("Inventory", "Asset");

			MapToStoredProcedures();
		}
	}
}