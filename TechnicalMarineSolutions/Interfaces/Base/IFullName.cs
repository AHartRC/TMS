namespace TechnicalMarineSolutions.Interfaces.Base
{
	public interface IFullName
	{
		/// <summary>
		///     The First (Given) Name of the person
		/// </summary>
		string FirstName
		{
			get;
			set;
		}

		/// <summary>
		///     The Middle Name of the person
		/// </summary>
		string MiddleName
		{
			get;
			set;
		}

		/// <summary>
		///     The Last (Sur) Name of the Person
		/// </summary>
		string LastName
		{
			get;
			set;
		}
	}
}