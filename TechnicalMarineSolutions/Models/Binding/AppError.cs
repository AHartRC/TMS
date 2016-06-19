namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System;
	using System.Collections.Generic;
	using TechnicalMarineSolutions.Interfaces.Binding;

	#endregion

	public class AppError : IAppError
	{
		public AppError()
		{
			Appointments = new HashSet<Appointment>();
			Categories = new HashSet<Category>();
			Components = new HashSet<Component>();
			Engines = new HashSet<Engine>();
			Images = new HashSet<Image>();
			UserInformation = new HashSet<Information>();
			Inventories = new HashSet<Inventory>();
			Manufacturers = new HashSet<Manufacturer>();
			Orders = new HashSet<Order>();
			Parts = new HashSet<Part>();
			PartOrderItems = new HashSet<PartOrderItem>();
			Addresses = new HashSet<PostalAddress>();
			Projects = new HashSet<Project>();
			Steps = new HashSet<Step>();
			SubCategories = new HashSet<SubCategory>();
			TertiaryCategories = new HashSet<TertiaryCategory>();
			Users = new HashSet<User>();
			Vehicles = new HashSet<Vehicle>();
			WorkOrderItems = new HashSet<WorkOrderItem>();
		}

		#region Implementation of IElmahError

		public Guid ErrorId
		{
			get;
			set;
		}

		public string Application
		{
			get;
			set;
		}

		public string Host
		{
			get;
			set;
		}

		public string Type
		{
			get;
			set;
		}

		public string Source
		{
			get;
			set;
		}

		public string Message
		{
			get;
			set;
		}

		public string User
		{
			get;
			set;
		}

		public int StatusCode
		{
			get;
			set;
		}

		public DateTime TimeUtc
		{
			get;
			set;
		}

		public int Sequence
		{
			get;
			set;
		}

		public string AllXml
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

		#region Implementation of IManyCategoryable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Category" /> Records
		/// </summary>
		public ICollection<Category> Categories
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

		#region Implementation of IManyInformationable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Information" /> Records
		/// </summary>
		public ICollection<Information> UserInformation
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

		#region Implementation of IManyManufacturerable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Manufacturer" /> Records
		/// </summary>
		public ICollection<Manufacturer> Manufacturers
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyOrderable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Order" /> Records
		/// </summary>
		public ICollection<Order> Orders
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyPartable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Part" /> Records
		/// </summary>
		public ICollection<Part> Parts
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

		#region Implementation of IManyPostalAddressable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.PostalAddress" /> Records
		/// </summary>
		public ICollection<PostalAddress> Addresses
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

		#region Implementation of IManySubCategoryable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.SubCategory" /> Records
		/// </summary>
		public ICollection<SubCategory> SubCategories
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyTertiaryCategoryable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.TertiaryCategory" /> Records
		/// </summary>
		public ICollection<TertiaryCategory> TertiaryCategories
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyUserable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.User" /> Records
		/// </summary>
		public ICollection<User> Users
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

		#region Implementation of IManyWorkOrderItemable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.WorkOrderItem" /> Records
		/// </summary>
		public ICollection<WorkOrderItem> WorkOrderItems
		{
			get;
			set;
		}

		#endregion
	}
}