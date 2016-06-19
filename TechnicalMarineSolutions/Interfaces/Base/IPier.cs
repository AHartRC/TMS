namespace TechnicalMarineSolutions.Interfaces.Base
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IPier
	{
		/// <summary>
		///     The identifier of the specific pier at the <see cref="PostalAddress" />
		/// </summary>
		string Pier
		{
			get;
			set;
		}

		/// <summary>
		///     The specific position of the <see cref="Pier" /> at the <see cref="PostalAddress" />
		/// </summary>
		string Position
		{
			get;
			set;
		}
	}
}