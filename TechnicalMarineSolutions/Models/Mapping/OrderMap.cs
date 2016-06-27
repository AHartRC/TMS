namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class OrderMap : EntityTypeConfiguration<Order>
	{
		public OrderMap()
		{
			ToTable("Order", "Order");

			//MapToStoredProcedures();
		}
	}
}