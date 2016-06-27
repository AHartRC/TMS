namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IPartOrderItemable
	{
		/// <summary>
		///     The ID of the <see cref="PartOrderItem" /> Record
		/// </summary>
		long PartOrderItemId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.PartOrderItem" /> Record
		/// </summary>
		PartOrderItem PartOrderItem
		{
			get;
			set;
		}
	}
}