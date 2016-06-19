namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	#region Library Imports

	#endregion

	public interface ITertiaryCategoryable
	{
		/// <summary>
		///     The ID of the <see cref="TertiaryCategory" /> Record
		/// </summary>
		long? TertiaryCategoryId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.TertiaryCategory" /> record
		/// </summary>
		TertiaryCategory TertiaryCategory
		{
			get;
			set;
		}
	}
}