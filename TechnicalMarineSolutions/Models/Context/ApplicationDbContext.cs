namespace TechnicalMarineSolutions.Models.Context
{
	#region Library Imports

	using System.Data.Entity;
	using System.Data.Entity.ModelConfiguration.Conventions;
	using Microsoft.AspNet.Identity.EntityFramework;
	using TechnicalMarineSolutions.Initializers;
	using TechnicalMarineSolutions.Models.Binding;
	using TechnicalMarineSolutions.Models.Mapping;

	#endregion

	public class ApplicationDbContext : IdentityDbContext<User>
	{
		static ApplicationDbContext()
		{
			Database.SetInitializer(new ApplicationDbContextInitializer());
		}

		public ApplicationDbContext()
			: base("DefaultConnection", false) {}

		public ApplicationDbContext(string connName)
			: base(connName, false) {}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("dbo");

			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			#region Table Mappings (Fluent-API Mapping)

			// There should be one map per model that appears in the Models/Binding folder

			modelBuilder.Configurations.Add(new AppErrorMap());
			modelBuilder.Configurations.Add(new AppointmentMap());
			modelBuilder.Configurations.Add(new CategoryMap());
			modelBuilder.Configurations.Add(new ComponentMap());
			modelBuilder.Configurations.Add(new EngineMap());
			modelBuilder.Configurations.Add(new ImageMap());
			modelBuilder.Configurations.Add(new InformationMap());
			modelBuilder.Configurations.Add(new InventoryMap());
			modelBuilder.Configurations.Add(new ManufacturerMap());
			modelBuilder.Configurations.Add(new OrderMap());
			modelBuilder.Configurations.Add(new PartMap());
			modelBuilder.Configurations.Add(new PartOrderItemMap());
			modelBuilder.Configurations.Add(new PostalAddressMap());
			modelBuilder.Configurations.Add(new ProjectMap());
			modelBuilder.Configurations.Add(new StepMap());
			modelBuilder.Configurations.Add(new SubCategoryMap());
			modelBuilder.Configurations.Add(new TertiaryCategoryMap());
			modelBuilder.Configurations.Add(new UserMap());
			modelBuilder.Configurations.Add(new VehicleMap());
			modelBuilder.Configurations.Add(new WorkOrderItemMap());

			#endregion Table Mappings (Fluent-API Mapping)

			base.OnModelCreating(modelBuilder);
		}

		#region Tables

		public virtual DbSet<AppError> Errors
		{
			get;
			set;
		}

		public virtual DbSet<Appointment> Appointments
		{
			get;
			set;
		}

		public virtual DbSet<Category> Categories
		{
			get;
			set;
		}

		public virtual DbSet<SubCategory> SubCategories
		{
			get;
			set;
		}

		public virtual DbSet<TertiaryCategory> TertiaryCategories
		{
			get;
			set;
		}

		public virtual DbSet<Component> Components
		{
			get;
			set;
		}

		public virtual DbSet<Engine> Engines
		{
			get;
			set;
		}

		public virtual DbSet<Image> Images
		{
			get;
			set;
		}

		public virtual DbSet<Information> UserInformation
		{
			get;
			set;
		}

		public virtual DbSet<Inventory> Inventories
		{
			get;
			set;
		}

		public virtual DbSet<Manufacturer> Manufacturers
		{
			get;
			set;
		}

		public virtual DbSet<Order> Orders
		{
			get;
			set;
		}

		public virtual DbSet<PartOrderItem> PartOrderItems
		{
			get;
			set;
		}

		public virtual DbSet<WorkOrderItem> WorkOrderItems
		{
			get;
			set;
		}

		public virtual DbSet<Part> Parts
		{
			get;
			set;
		}

		public virtual DbSet<PostalAddress> PostalAddresses
		{
			get;
			set;
		}

		public virtual DbSet<Project> Projects
		{
			get;
			set;
		}

		public virtual DbSet<Step> Steps
		{
			get;
			set;
		}

		public virtual DbSet<Vehicle> Vehicles
		{
			get;
			set;
		}

		#endregion Tables
	}
}