namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IInventoryable
	{
		/// <summary>
		///     The ID of the <see cref="Inventory" /> Record
		/// </summary>
		long InventoryId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Inventory" /> Record
		/// </summary>
		Inventory Inventory
		{
			get;
			set;
		}
	}
}