namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IStepable
	{
		/// <summary>
		///     The ID of the <see cref="Step" /> Record
		/// </summary>
		long StepId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Step" /> Record
		/// </summary>
		Step Step
		{
			get;
			set;
		}
	}
}