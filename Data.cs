using System;
using System.Collections.Generic;
using System.Text;

namespace TokenBusApp
{
    public class Data
    {
		 private static readonly int DATA_SIZE_BYTES = 100;
		 private byte[] m_szbData;

		 public Data()
		 {
			this.m_szbData = new byte[DATA_SIZE_BYTES];
		 }
		 
		 public Data(string _data)
		 {
			 ASCIIEncoding encoding = new ASCIIEncoding();
			 this.m_szbData = encoding.GetBytes(_data);

			 if (this.m_szbData.Length > DATA_SIZE_BYTES)
			 {
				 throw new ArgumentException("Inputa data too long");
			 }
		 }

		 public override string ToString()
		 {
				ASCIIEncoding enc = new ASCIIEncoding();
				return enc.GetString(this.m_szbData);
		 }
    }
}
