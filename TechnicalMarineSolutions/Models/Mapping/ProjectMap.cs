#region Library Imports

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Models.Mapping
{
	public class ProjectMap : EntityTypeConfiguration<Project>
	{
		public ProjectMap()
		{
			ToTable("Project", "Work");

			HasKey(k => k.Id);

			Property(p => p.Id)

				// .HasColumnAnnotation("", )
				.HasColumnName("Id")
				.HasColumnOrder(1)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
				.HasParameterName("Id")
				.IsRequired();

			Property(p => p.RecordStatus)

				// .HasColumnAnnotation("", )
				.HasColumnName("RecordStatus")
				.HasColumnOrder(2)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("RecordStatus")
				.IsRequired();

			Property(p => p.ProjectStatus)

				// .HasColumnAnnotation("", )
				.HasColumnName("ProjectStatus")
				.HasColumnOrder(3)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("ProjectStatus")
				.IsRequired();

			Property(p => p.Name)

				// .HasColumnAnnotation("", )
				.HasColumnName("Name")
				.HasColumnOrder(4)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(256)
				.HasParameterName("Name")
				.IsRequired();

			Property(p => p.Description)

				// .HasColumnAnnotation("", )
				.HasColumnName("Description")
				.HasColumnOrder(5)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(null)
				.HasParameterName("Description")
				.IsOptional();

			Property(p => p.Notes)

				// .HasColumnAnnotation("", )
				.HasColumnName("Notes")
				.HasColumnOrder(6)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(null)
				.HasParameterName("Notes")
				.IsOptional();

			Property(p => p.ProjectedStartDate)

				// .HasColumnAnnotation("", )
				.HasColumnName("ProjectedStartDate")
				.HasColumnOrder(7)
				.HasColumnType("DATETIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("ProjectedStartDate")
				.IsOptional();

			Property(p => p.ProjectedEndDate)

				// .HasColumnAnnotation("", )
				.HasColumnName("ProjectedEndDate")
				.HasColumnOrder(8)
				.HasColumnType("DATETIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("ProjectedEndDate")
				.IsOptional();

			Property(p => p.EstimatedDuration)

				// .HasColumnAnnotation("", )
				.HasColumnName("EstimatedDuration")
				.HasColumnOrder(9)
				.HasColumnType("TIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("EstimatedDuration")
				.IsOptional();

			Property(p => p.StartDate)

				// .HasColumnAnnotation("", )
				.HasColumnName("StartDate")
				.HasColumnOrder(10)
				.HasColumnType("DATETIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("StartDate")
				.IsOptional();

			Property(p => p.EndDate)

				// .HasColumnAnnotation("", )
				.HasColumnName("EndDate")
				.HasColumnOrder(11)
				.HasColumnType("DATETIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("EndDate")
				.IsOptional();

			Property(p => p.TotalDuration)

				// .HasColumnAnnotation("", )
				.HasColumnName("TotalDuration")
				.HasColumnOrder(12)
				.HasColumnType("TIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("TotalDuration")
				.IsOptional();

			HasMany(m => m.ProjectTasks)
				.WithRequired(r => r.Project)
				.HasForeignKey(fk => fk.ProjectId);

			HasMany(m => m.ProjectAppointments)
				.WithRequired(r => r.Project)
				.HasForeignKey(fk => fk.ProjectId);

			HasMany(m => m.ProjectImages)
				.WithRequired(r => r.Project)
				.HasForeignKey(fk => fk.ProjectId);
		}
	}
}