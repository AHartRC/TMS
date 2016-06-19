namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IProjectable
	{
		/// <summary>
		///     The ID of the <see cref="Project" /> Record
		/// </summary>
		long ProjectId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Project" /> Record
		/// </summary>
		Project Project
		{
			get;
			set;
		}
	}
}