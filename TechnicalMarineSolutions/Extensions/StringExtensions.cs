namespace TechnicalMarineSolutions.Extensions
{
	public static class StringExtensions
	{
		public static byte[] ToBytes(this string hex)
		{
			byte[] output = new byte[hex.Length / 2];
			for (int nChar = 0; nChar < hex.Length; nChar += 2)
				output[nChar / 2] = hex.ToByte(nChar);
			return output;
		}

		public static byte ToByte(this string hex, int offset)
		{
			return (byte) (hex[offset].ToNibble() * 16 + hex[offset + 1].ToNibble());
		}
	}
}