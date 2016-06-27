namespace TechnicalMarineSolutions.Models.Base
{
	#region Library Imports

	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations.Schema;
	using TechnicalMarineSolutions.Enumerators;
	using TechnicalMarineSolutions.Hashing;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public abstract class BaseModel : IBaseModel
	{
		#region Implementation of IIdentifier

		/// <summary>
		///     The Primary Identifier of the record. This is typically the primary key column.
		/// </summary>
		public long Id
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IEntityType

		/// <summary>
		///     An identifier that distinguishes one entity type from another
		/// </summary>
		[NotMapped]
		public long EntityTypeId => MurmurHash3.GetHashAsLong(GetType().FullName);

		#endregion

	    #region Implementation of IRecordStatus

	    /// <summary>
	    ///     The Current status of the Record
	    ///     <para>This is to be used for internal purposes</para>
	    ///     This field will be utilized for flagging records as spam/archived/deleted/featured/etc
	    /// </summary>
	    public RecordStatus RecordStatus
	    {
	        get;
	        set;
	    }

	    #endregion
	}
}