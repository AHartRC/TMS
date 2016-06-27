namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class AppErrorMap : EntityTypeConfiguration<AppError>
	{
		public AppErrorMap()
		{
			ToTable("ELMAH_Error", "dbo");

			//MapToStoredProcedures();
		}
	}
}