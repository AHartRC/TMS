namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System;
	using System.Collections.Generic;
	using TechnicalMarineSolutions.Enumerators;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;
	using TechnicalMarineSolutions.Models.Base;

	#endregion

	public class Step : BaseModel, IStep
	{
		public Step()
		{
		}

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

		#region Implementation of IDuration

		/// <summary>
		///     The scheduled interval. Defaults to Once (0).
		/// </summary>
		public DurationInterval Interval
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the event started
		/// </summary>
		public DateTime? StartDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the event ended
		/// </summary>
		public DateTime? EndDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Total Duration of the event
		///     <para>This field indicates how long specifically that the event took</para>
		///     This is to differentiate the amount of time between the start and end dates versus time actually spent towards the
		///     corresponding event
		/// </summary>
		public TimeSpan? Duration
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

		#region Implementation of IStep

		/// <summary>
		///     The level of difficulty of the step
		/// </summary>
		public DifficultyLevel Difficulty
		{
			get;
			set;
		}

		#endregion
	}
}