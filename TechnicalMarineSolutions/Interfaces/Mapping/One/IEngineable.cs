namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IEngineable
	{
		/// <summary>
		///     The ID of the <see cref="Engine" /> Record
		/// </summary>
		long? EngineId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Engine" /> Record
		/// </summary>
		Engine Engine
		{
			get;
			set;
		}
	}
}