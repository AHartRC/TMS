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

	public class Vehicle : BaseModel, IVehicle
	{
		public Vehicle()
		{
		}

		#region Implementation of IManufacturerable

		/// <summary>
		///     The ID of the <see cref="IManufacturerable.Manufacturer" /> Record
		/// </summary>
		public long ManufacturerId
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
		public long CategoryId
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
		public long SubCategoryId
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
		public long TertiaryCategoryId
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
		///         Values such as 98.6 will be treated as 9860%.
		///     </value>
		/// </summary>
		public decimal Discount
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

		#region Implementation of IVehicle

		/// <summary>
		///     The unique Vehicle Identification Number
		/// </summary>
		public string VIN
		{
			get;
			set;
		}

		/// <summary>
		///     The Year of manufacturer
		/// </summary>
		public int Year
		{
			get;
			set;
		}

		/// <summary>
		///     The Make of the Vehicle
		/// </summary>
		public string Make
		{
			get;
			set;
		}

		/// <summary>
		///     The Model of the Vehicle
		/// </summary>
		public string Model
		{
			get;
			set;
		}

		/// <summary>
		///     The Edition of the Vehicle
		/// </summary>
		public string Edition
		{
			get;
			set;
		}

		#endregion
	}
}