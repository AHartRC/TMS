namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Enumerators;
	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;
	using TechnicalMarineSolutions.Models.Base;

	#endregion

	public class Part : BaseModel, IPart
	{
		public Part()
		{
			Appointments = new HashSet<Appointment>();
			Components = new HashSet<Component>();
			Engines = new HashSet<Engine>();
			Errors = new HashSet<AppError>();
			Images = new HashSet<Image>();
			Inventories = new HashSet<Inventory>();
			PartOrderItems = new HashSet<PartOrderItem>();
			Projects = new HashSet<Project>();
			Steps = new HashSet<Step>();
			Vehicles = new HashSet<Vehicle>();
		}
		#region Implementation of IManufacturerable

		/// <summary>
		///     The ID of the <see cref="IManufacturerable.Manufacturer" /> Record
		/// </summary>
		public long? ManufacturerId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Manufacturer" /> Record
		/// </summary>
		public Manufacturer Manufacturer
		{
			get;
			set;
		}

		#endregion

		#region Implementation of ICategoryable

		/// <summary>
		///     The ID of the <see cref="ICategoryable.Category" /> Record
		/// </summary>
		public long? CategoryId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Category" /> record
		/// </summary>
		public Category Category
		{
			get;
			set;
		}

		#endregion

		#region Implementation of ISubCategoryable

		/// <summary>
		///     The ID of the <see cref="ISubCategoryable.SubCategory" /> Record
		/// </summary>
		public long? SubCategoryId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.SubCategory" /> record
		/// </summary>
		public SubCategory SubCategory
		{
			get;
			set;
		}

		#endregion

		#region Implementation of ITertiaryCategoryable

		/// <summary>
		///     The ID of the <see cref="ITertiaryCategoryable.TertiaryCategory" /> Record
		/// </summary>
		public long? TertiaryCategoryId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.TertiaryCategory" /> record
		/// </summary>
		public TertiaryCategory TertiaryCategory
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IRetailItem

		/// <summary>
		///     The Universal Product Code that corresponds to the item
		/// </summary>
		public string UPC
		{
			get;
			set;
		}

		/// <summary>
		///     A unique identifier typically assigned by a third party
		/// </summary>
		public string PartNumber
		{
			get;
			set;
		}

		/// <summary>
		///     The type of packaging that the item is sold in
		/// </summary>
		public PackageType PackageType
		{
			get;
			set;
		}

		/// <summary>
		///     The current condition of the item
		/// </summary>
		public ItemCondition Condtion
		{
			get;
			set;
		}

		#endregion

		#region Implementation of ICost

		/// <summary>
		///     <para>The Cost of the Item</para>
		/// </summary>
		public decimal Cost
		{
			get;
			set;
		}

		/// <summary>
		///     The Discount Percentage to be applied to <see cref="ICost.Cost" />
		///     <value>
		///         <para>The expected value should be already reduced to 0.#</para>
		///         Values such as 98.6 will be treated as 986%.
		///     </value>
		/// </summary>
		public decimal Discount
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IQuantity

		/// <summary>
		///     The total amount of the item
		/// </summary>
		public decimal Quantity
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IName

		/// <summary>
		///     A Brief Name that describes the content in as few words as possible
		/// </summary>
		public string Name
		{
			get;
			set;
		}

		#endregion

		#region Implementation of ITitle

		/// <summary>
		///     A Title or Caption that describes the record
		/// </summary>
		public string Title
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IDescription

		/// <summary>
		///     A brief description that describes what this record entails
		/// </summary>
		public string Description
		{
			get;
			set;
		}

		#endregion

		#region Implementation of INote

		/// <summary>
		///     Notes that are available to the public
		/// </summary>
		public string PublicNotes
		{
			get;
			set;
		}

		/// <summary>
		///     Notes that are available to administrators and moderators only
		/// </summary>
		public string PrivateNotes
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyAppointmentable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Appointment" /> Records
		/// </summary>
		public ICollection<Appointment> Appointments
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyComponentable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Component" /> Records
		/// </summary>
		public ICollection<Component> Components
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyEngineable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Engine" /> Records
		/// </summary>
		public ICollection<Engine> Engines
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyImageable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Image" /> Records
		/// </summary>
		public ICollection<Image> Images
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyInventoryable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Inventory" /> Records
		/// </summary>
		public ICollection<Inventory> Inventories
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyPartOrderItemable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.PartOrderItem" /> Records
		/// </summary>
		public ICollection<PartOrderItem> PartOrderItems
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyProjectable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Project" /> Records
		/// </summary>
		public ICollection<Project> Projects
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyStepable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Step" /> Records
		/// </summary>
		public ICollection<Step> Steps
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyVehicleable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Vehicle" /> Records
		/// </summary>
		public ICollection<Vehicle> Vehicles
		{
			get;
			set;
		}

		#endregion
	}
}