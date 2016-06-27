namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Models.Base;

	#endregion

	public class Image : BaseModel, IImage
	{
		public Image()
		{
		}

		#region Implementation of IMedia

		/// <summary>
		///     The file path or URL of the Media
		/// </summary>
		public string Source
		{
			get;
			set;
		}

		/// <summary>
		///     Text to display if the <see cref="IMedia.Source" /> is invalid
		/// </summary>
		public string AlternateText
		{
			get;
			set;
		}

		#endregion

		#region Implementation of I2Dimension

		/// <summary>
		///     <para>The Width of the Object</para>
		/// </summary>
		public decimal Width
		{
			get;
			set;
		}

		/// <summary>
		///     <para>The Height of the Object</para>
		/// </summary>
		public decimal Height
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IName

		/// <summary>
		///     A Brief Name that describes the content in as few words as possible
		/// </summary>
		public string Name
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IAuthor

		/// <summary>
		///     <para>The Name of the Author that created the content</para>
		/// </summary>
		public string Author
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IDescription

		/// <summary>
		///     A brief description that describes what this record entails
		/// </summary>
		public string Description
		{
			get;
			set;
		}

		#endregion

		#region Implementation of INote

		/// <summary>
		///     Notes that are available to the public
		/// </summary>
		public string PublicNotes
		{
			get;
			set;
		}

		/// <summary>
		///     Notes that are available to administrators and moderators only
		/// </summary>
		public string PrivateNotes
		{
			get;
			set;
		}

		#endregion
	}
}