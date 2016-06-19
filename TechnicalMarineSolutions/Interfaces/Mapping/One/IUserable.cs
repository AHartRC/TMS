namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IUserable
	{
		/// <summary>
		///     The ID of the <see cref="User" /> Record
		/// </summary>
		long UserId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.User" /> Record
		/// </summary>
		User User
		{
			get;
			set;
		}
	}
}