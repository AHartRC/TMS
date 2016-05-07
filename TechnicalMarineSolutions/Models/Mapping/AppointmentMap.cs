#region Library Imports

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Models.Mapping
{
	public class AppointmentMap : EntityTypeConfiguration<Appointment>
	{
		public AppointmentMap()
		{
			ToTable("Appointment", "Work");

			HasKey(k => k.Id);

			Property(p => p.Id)

				// .HasColumnAnnotation("", )
				.HasColumnName("Id")
				.HasColumnOrder(1)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
				.HasParameterName("Id")
				.IsRequired();

			Property(p => p.PostalAddressId)

				// .HasColumnAnnotation("", )
				.HasColumnName("PostalAddressId")
				.HasColumnOrder(2)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PostalAddressId")
				.IsRequired();

			Property(p => p.RecordStatus)

				// .HasColumnAnnotation("", )
				.HasColumnName("RecordStatus")
				.HasColumnOrder(3)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("RecordStatus")
				.IsRequired();

			Property(p => p.AppointmentStatus)

				// .HasColumnAnnotation("", )
				.HasColumnName("AppointmentStatus")
				.HasColumnOrder(4)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("AppointmentStatus")
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

			Property(p => p.ScheduledDate)

				// .HasColumnAnnotation("", )
				.HasColumnName("ScheduledDate")
				.HasColumnOrder(8)
				.HasColumnType("DATETIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("ScheduledDate")
				.IsOptional();

			Property(p => p.StartDate)

				// .HasColumnAnnotation("", )
				.HasColumnName("StartDate")
				.HasColumnOrder(9)
				.HasColumnType("DATETIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("StartDate")
				.IsOptional();

			Property(p => p.EndDate)

				// .HasColumnAnnotation("", )
				.HasColumnName("EndDate")
				.HasColumnOrder(10)
				.HasColumnType("DATETIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("EndDate")
				.IsOptional();

			Property(p => p.ScheduledDuration)
				.HasPrecision(7)

				// .HasColumnAnnotation("", )
				.HasColumnName("ScheduledDuration")
				.HasColumnOrder(11)
				.HasColumnType("TIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("ScheduledDuration")
				.IsOptional();

			Property(p => p.EstimatedDuration)
				.HasPrecision(7)

				// .HasColumnAnnotation("", )
				.HasColumnName("EstimatedDuration")
				.HasColumnOrder(12)
				.HasColumnType("TIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("EstimatedDuration")
				.IsOptional();

			Property(p => p.TotalDuration)
				.HasPrecision(7)

				// .HasColumnAnnotation("", )
				.HasColumnName("TotalDuration")
				.HasColumnOrder(13)
				.HasColumnType("TIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("TotalDuration")
				.IsOptional();

			HasRequired(r => r.PostalAddress)
				.WithMany(m => m.Appointments)
				.HasForeignKey(fk => fk.PostalAddressId);

			HasMany(m => m.AppointmentImages)
				.WithRequired(r => r.Appointment)
				.HasForeignKey(fk => fk.AppointmentId);

			HasMany(m => m.AppointmentTasks)
				.WithRequired(r => r.Appointment)
				.HasForeignKey(fk => fk.AppointmentId);

			HasMany(m => m.ProjectAppointments)
				.WithRequired(r => r.Appointment)
				.HasForeignKey(fk => fk.AppointmentId);
		}
	}
}