namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class WorkOrderItemMap : EntityTypeConfiguration<WorkOrderItem>
	{
		public WorkOrderItemMap()
		{
			ToTable("WorkOrderItem", "Order");

			MapToStoredProcedures();
		}
	}
}