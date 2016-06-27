namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IComponentable
	{
		/// <summary>
		///     The ID of the <see cref="Component" /> Record
		/// </summary>
		long ComponentId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Component" /> Record
		/// </summary>
		Component Component
		{
			get;
			set;
		}
	}
}