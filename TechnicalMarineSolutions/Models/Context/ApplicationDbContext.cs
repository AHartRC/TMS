#region Library Imports

using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using TechnicalMarineSolutions.Models.Binding;
using TechnicalMarineSolutions.Models.Mapping;

#endregion

namespace TechnicalMarineSolutions.Models.Context
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext()
			: base("DefaultConnection", false)
		{
		}

		public ApplicationDbContext(string connName)
			: base(connName, false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("dbo");

			#region Table Mappings (Fluent-API Mapping)

			// There should be one map per model that appears in the Models/Binding folder

			modelBuilder.Configurations.Add(new ApplicationUserMap());
			modelBuilder.Configurations.Add(new UserInfoMap());
			modelBuilder.Configurations.Add(new PersonalInfoMap());
			modelBuilder.Configurations.Add(new PostalAddressMap());
			modelBuilder.Configurations.Add(new TaskMap());
			modelBuilder.Configurations.Add(new ProjectMap());
			modelBuilder.Configurations.Add(new AppointmentMap());
			modelBuilder.Configurations.Add(new ProjectTaskMap());
			modelBuilder.Configurations.Add(new ProjectAppointmentMap());
			modelBuilder.Configurations.Add(new AppointmentTaskMap());
			modelBuilder.Configurations.Add(new ImageMap());
			modelBuilder.Configurations.Add(new TaskImageMap());
			modelBuilder.Configurations.Add(new ProjectImageMap());
			modelBuilder.Configurations.Add(new AppointmentImageMap());

			#endregion Table Mappings (Fluent-API Mapping)

			base.OnModelCreating(modelBuilder);
		}

		#region Tables

		public virtual DbSet<AppointmentImage> AppointmentImages
		{
			get;
			set;
		}

		public virtual DbSet<Image> Images
		{
			get;
			set;
		}

		public virtual DbSet<ProjectImage> ProjectImages
		{
			get;
			set;
		}

		public virtual DbSet<TaskImage> TaskImages
		{
			get;
			set;
		}

		public virtual DbSet<Person> PersonalInfoes
		{
			get;
			set;
		}

		public virtual DbSet<PostalAddress> PostalAddresses
		{
			get;
			set;
		}

		public virtual DbSet<User> UserInfoes
		{
			get;
			set;
		}

		public virtual DbSet<Appointment> Appointments
		{
			get;
			set;
		}

		public virtual DbSet<AppointmentTask> AppointmentTasks
		{
			get;
			set;
		}

		public virtual DbSet<Project> Projects
		{
			get;
			set;
		}

		public virtual DbSet<ProjectAppointment> ProjectAppointments
		{
			get;
			set;
		}

		public virtual DbSet<ProjectTask> ProjectTasks
		{
			get;
			set;
		}

		public virtual DbSet<Task> Tasks
		{
			get;
			set;
		}

		#endregion Tables
	}
}