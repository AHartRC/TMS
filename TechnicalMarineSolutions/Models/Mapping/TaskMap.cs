#region Library Imports

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Models.Mapping
{
	public class TaskMap : EntityTypeConfiguration<Task>
	{
		public TaskMap()
		{
			ToTable("Task", "Work");

			HasKey(k => k.Id);

			Property(p => p.Id)

				// .HasColumnAnnotation("", )
				.HasColumnName("Id")
				.HasColumnOrder(1)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
				.IsRequired();

			Property(p => p.RecordStatus)

				// .HasColumnAnnotation("", )
				.HasColumnName("RecordStatus")
				.HasColumnOrder(2)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("RecordStatus")
				.IsRequired();

			Property(p => p.Difficulty)

				// .HasColumnAnnotation("", )
				.HasColumnName("Difficulty")
				.HasColumnOrder(3)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("Difficulty")
				.IsRequired();

			Property(p => p.EstimatedDuration)
				.HasPrecision(7)

				// .HasColumnAnnotation("", )
				.HasColumnName("EstimatedDuration")
				.HasColumnOrder(4)
				.HasColumnType("TIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("EstimatedDuration")
				.IsRequired();

			Property(p => p.Name)

				// .HasColumnAnnotation("", )
				.HasColumnName("Name")
				.HasColumnOrder(5)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(256)
				.HasParameterName("Name")
				.IsRequired();

			Property(p => p.Description)

				// .HasColumnAnnotation("", )
				.HasColumnName("Description")
				.HasColumnOrder(6)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(null)
				.HasParameterName("Description")
				.IsOptional();

			Property(p => p.Notes)

				// .HasColumnAnnotation("", )
				.HasColumnName("Notes")
				.HasColumnOrder(7)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(null)
				.HasParameterName("Notes")
				.IsOptional();

			HasMany(m => m.AppointmentTasks)
				.WithRequired(r => r.Task)
				.HasForeignKey(fk => fk.TaskId);

			HasMany(m => m.ProjectTasks)
				.WithRequired(r => r.Task)
				.HasForeignKey(fk => fk.TaskId);

			HasMany(m => m.TaskImages)
				.WithRequired(r => r.Task)
				.HasForeignKey(fk => fk.TaskId);
		}
	}
}