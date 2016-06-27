namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IInformationable
	{
		/// <summary>
		///     The ID of the <see cref="Information" /> Record
		/// </summary>
		long InformationId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Information" /> Record
		/// </summary>
		Information Information
		{
			get;
			set;
		}
	}
}