#region Library Imports

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Models.Mapping
{
	public class UserInfoMap : EntityTypeConfiguration<User>
	{
		public UserInfoMap()
		{
			ToTable("UserInformation", "User");

			HasKey(k => k.Id);

			Property(p => p.Id)

				// .HasColumnAnnotation("", )
				.HasColumnName("Id")
				.HasColumnOrder(1)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
				.HasParameterName("Id")
				.IsRequired();

			Property(p => p.UserId)

				// .HasColumnAnnotation("", )
				.HasColumnName("UserId")
				.HasColumnOrder(2)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("UserId")
				.IsRequired();

			Property(p => p.DisplayName)

				// .HasColumnAnnotation("", )
				.HasColumnName("DisplayName")
				.HasColumnOrder(3)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("DisplayName")
				.IsRequired();

			HasRequired(r => r.User)
				.WithMany(m => m.Users)
				.HasForeignKey(fk => fk.UserId);

			HasMany(m => m.People)
				.WithRequired(r => r.User)
				.HasForeignKey(fk => fk.UserId);
		}
	}
}