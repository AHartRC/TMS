namespace TechnicalMarineSolutions.Interfaces.Base
{
	public interface IMedia
	{
		/// <summary>
		///     The file path or URL of the Media
		/// </summary>
		string Source
		{
			get;
			set;
		}

		/// <summary>
		///     Text to display if the <see cref="Source" /> is invalid
		/// </summary>
		string AlternateText
		{
			get;
			set;
		}
	}
}