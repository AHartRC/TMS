namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	#region Library Imports

	#endregion

	public interface ISubCategoryable
	{
		/// <summary>
		///     The ID of the <see cref="SubCategory" /> Record
		/// </summary>
		long? SubCategoryId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.SubCategory" /> record
		/// </summary>
		SubCategory SubCategory
		{
			get;
			set;
		}
	}
}