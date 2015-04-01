using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Problem05
{
    public class BitArray64:IEnumerable<int>
    {
        private ulong number;

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public BitArray64(ulong number)
        {
            this.Number = number;
        }
        public byte this[int index]
        {
            get
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException();
                }
                return (byte)((this.Number >> index) & 1);
            }
            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException();
                }
                if (value > 1 || value < 0)
                {
                    throw new ArgumentException();
                }
                if (value == 1)
                {
                    this.Number = this.Number | ((ulong)1 << index);
                }
                else 
                {
                    this.Number = this.Number & ~((ulong)1 << index);
                }
            }
        }

        public static bool operator ==(BitArray64 obj1,BitArray64 obj2)
        {
            return BitArray64.Equals(obj1, obj2);
        }
        public static bool operator !=(BitArray64 obj1,BitArray64 obj2)
        {
            return !BitArray64.Equals(obj1, obj2);
        }
        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BitArray64 bitArr = obj as BitArray64;
            if (bitArr == null)
            {
                return false;
            }
            return Object.Equals(this.Number,bitArr.Number);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                result.Insert(0, ((this.Number >> i) & 1));
            }

            return result.ToString();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
