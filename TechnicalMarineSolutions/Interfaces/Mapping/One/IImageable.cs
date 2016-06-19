namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IImageable
	{
		/// <summary>
		///     The ID of the <see cref="Image" /> Record
		/// </summary>
		long? ImageId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Image" /> Record
		/// </summary>
		Image Image
		{
			get;
			set;
		}
	}
}