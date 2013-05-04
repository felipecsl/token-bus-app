using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace TokenBusApp
{
	/// <summary>
	/// Converts a object to its byte array representation and vice-versa
	/// </summary>
	public class ObjectByteArrayConverter
	{
		public static byte[] ObjectToByteArray(Object obj)
		{
			using (MemoryStream memStream1 = new MemoryStream())
			{
				BinaryFormatter formatter = new BinaryFormatter();

				formatter.Serialize(memStream1, obj);

				return memStream1.GetBuffer();
			}
		}

		public static object ByteArrayToObject(byte[] bytes)
		{
			using (MemoryStream memStream2 = new MemoryStream(bytes))
			{
				BinaryFormatter formatter = new BinaryFormatter();

				return formatter.Deserialize(memStream2);
			}
		}
	}
}
