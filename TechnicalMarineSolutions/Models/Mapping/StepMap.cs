namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class StepMap : EntityTypeConfiguration<Step>
	{
		public StepMap()
		{
			ToTable("Step", "Work");

			//MapToStoredProcedures();
		}
	}
}