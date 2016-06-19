namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	#region Library Imports

	#endregion

	public interface ICategoryable
	{
		/// <summary>
		///     The ID of the <see cref="Category" /> Record
		/// </summary>
		long? CategoryId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Category" /> record
		/// </summary>
		Category Category
		{
			get;
			set;
		}
	}
}