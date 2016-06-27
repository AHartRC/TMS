namespace TechnicalMarineSolutions.Interfaces.Base
{
	public interface ICost
	{
		/// <summary>
		///     <para>The Cost of the Item</para>
		/// </summary>
		decimal Cost
		{
			get;
			set;
		}

		/// <summary>
		///     The Discount Percentage to be applied to <see cref="Cost" />
		///     <value>
		///         <para>The expected value should be already reduced to 0.#</para>
		///         Values such as 98.6 will be treated as 9860%.
		///     </value>
		/// </summary>
		decimal Discount
		{
			get;
			set;
		}
	}
}