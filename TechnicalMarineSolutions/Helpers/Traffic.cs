namespace TechnicalMarineSolutions.Helpers
{
	#region Library Imports

	using System;
	using System.Globalization;
	using System.IO;
	using System.Net;
	using System.Text;
	using System.Web.Script.Serialization;

	#endregion

	/// <summary>This class handled the various traffic that occurrs via applications that AH Operations develops.</summary>
	public class Traffic
	{
		/// <summary>Send a request to a specified Url using a pre-serialized JSON string for data</summary>
		/// <param name="url">The Url where the content resides</param>
		/// <param name="method">The method of the request</param>
		/// <param name="data">Any data to pass along with the request</param>
		/// <returns>The response of the request as a string</returns>
		public static string Http(string url, string method = "GET", string data = null)
		{
			method = method.ToUpper(CultureInfo.CurrentCulture);

			if (string.IsNullOrWhiteSpace(url))
				throw new ArgumentNullException("url", "You must provide a valid URL!");

			if (method != "GET" &&
				method != "POST" &&
				method != "PUT" &&
				method != "PATCH" &&
				method != "PUSH" &&
				method != "DELETE")
			{
				throw new ArgumentNullException("method",
												"You must provide a valid method! Valid entries are GET, POST, PUT, PATCH, PUSH, and DELETE.");
			}

			WebRequest webRequest = WebRequest.Create(url);
			webRequest.Method = method;
			webRequest.Credentials = CredentialCache.DefaultCredentials;

			if (!string.IsNullOrWhiteSpace(data))
			{
				byte[] byteArray = Encoding.UTF8.GetBytes(data);
				webRequest.ContentLength = byteArray.Length;
				webRequest.ContentType = "x-www-form-urlencoded"; // Maybe necessary. . . Commented for now
				using (Stream requestStream = webRequest.GetRequestStream())
					requestStream.Write(byteArray, 0, byteArray.Length);
			}

			using (WebResponse response = webRequest.GetResponse())
			{
				string charSet = ((HttpWebResponse) response).CharacterSet;
				string encoding = ((HttpWebResponse) response).ContentEncoding;
				long length = ((HttpWebResponse) response).ContentLength;
				string type = ((HttpWebResponse) response).ContentType;
				CookieCollection cookies = ((HttpWebResponse) response).Cookies;
				WebHeaderCollection headers = ((HttpWebResponse) response).Headers;
				bool isFromCache = ((HttpWebResponse) response).IsFromCache;
				bool isMutuallyAuthenticated = ((HttpWebResponse) response).IsMutuallyAuthenticated;
				DateTime lastModified = ((HttpWebResponse) response).LastModified;
				string responseMethod = ((HttpWebResponse) response).Method;
				Version protocolVersion = ((HttpWebResponse) response).ProtocolVersion;
				Uri responseUri = ((HttpWebResponse) response).ResponseUri;
				string server = ((HttpWebResponse) response).Server;
				HttpStatusCode status = ((HttpWebResponse) response).StatusCode;
				string statusdesc = ((HttpWebResponse) response).StatusDescription;
				bool supportsHeaders = ((HttpWebResponse) response).SupportsHeaders;

				using (Stream responseStream = response.GetResponseStream())
				{
					//var canRead = responseStream.CanRead;
					//var canSeek = responseStream.CanSeek;
					//var canTimeout = responseStream.CanTimeout;
					//var canWrite = responseStream.CanWrite;
					//var readTimeout = responseStream.ReadTimeout;
					//var writeTimeout = responseStream.WriteTimeout;

					using (StreamReader responseReader = new StreamReader(responseStream))
						return responseReader.ReadToEnd();
				}
			}
		}

		/// <summary>Send a request to a specified Url using a strongly-typed object for data</summary>
		/// <param name="url">The Url where the content resides</param>
		/// <param name="method">The method of the request</param>
		/// <param name="data">Any data to pass along with the request</param>
		/// <returns>The response of the request as a string</returns>
		public static string Http(string url, string method = "GET", object data = null)
		{
			return data != null
					   ? Http(url, method, Serialize(data))
					   : null;
		}

		/// <summary>Send a request to a specified Url using a pre-serialized JSON string for data</summary>
		/// <typeparam name="T">The type of object to deserialize the response into</typeparam>
		/// <param name="url">The Url where the content resides</param>
		/// <param name="method">The method of the request</param>
		/// <param name="data">Any data to pass along with the request</param>
		/// <returns>The response of the request in the type specified</returns>
		public static T Http<T>(string url, string method = "GET", string data = null) where T : class
		{
			string response = Http(url, method, data);
			return Deserialize<T>(response);
		}

		/// <summary>Send a request to a specified Url using a strongly-typed object for data</summary>
		/// <typeparam name="T">The type of object to deserialize the response into</typeparam>
		/// <param name="url">The Url where the content resides</param>
		/// <param name="method">The method of the request</param>
		/// <param name="data">Any data to pass along with the request</param>
		/// <returns>The response of the request in the type specified</returns>
		public static T Http<T>(string url, string method = "GET", object data = null) where T : class
		{
			string response = Http(url, method, data);
			return Deserialize<T>(response);
		}

		public static string Serialize(object obj)
		{
			if (obj == null)
				return null;
			JavaScriptSerializer jss = new JavaScriptSerializer();
			return jss.Serialize(obj);
		}

		public static T Deserialize<T>(string source) where T : class
		{
			if (string.IsNullOrWhiteSpace(source))
				return null;
			JavaScriptSerializer jss = new JavaScriptSerializer();
			T result = jss.Deserialize<T>(source);
			return result;
		}
	}
}