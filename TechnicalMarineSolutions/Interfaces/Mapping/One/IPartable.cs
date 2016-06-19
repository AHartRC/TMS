namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using System.Web.UI.WebControls.WebParts;

	#endregion

	public interface IPartable
	{
		/// <summary>
		///     The ID of the <see cref="Part" /> Record
		/// </summary>
		long PartId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Part" /> Record
		/// </summary>
		Part Part
		{
			get;
			set;
		}
	}
}