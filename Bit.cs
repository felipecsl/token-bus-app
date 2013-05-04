using System;
using System.Collections.Generic;
using System.Text;

namespace TokenBusApp
{
    public class Bit
    {
        private uint m_nValue = 0;

        public Bit(int value)
        {
            if (value != 0 &&
                value != 1)
            {
                throw new ArgumentException("Value not valid for a bit");
            }
            m_nValue = (uint)value;
        }

        public static explicit operator Bit(int i)
        {
            Bit b = new Bit(i);
            return b;
        }

			 public static explicit operator int(Bit i)
			 {
				 return (int)i.m_nValue;
			 }
    }
}
