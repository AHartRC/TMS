namespace TechnicalMarineSolutions.Extensions
{
	public static class CharExtensions
	{
		public static int ToNibble(this char hex)
		{
			return hex > '9'
					   ? hex - ('A' - 10)
					   : hex - '0';
		}
	}
}