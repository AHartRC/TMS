namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IOrderable
	{
		/// <summary>
		///     The ID of the <see cref="Order" /> Record
		/// </summary>
		long OrderId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Order" /> Record
		/// </summary>
		Order Order
		{
			get;
			set;
		}
	}
}