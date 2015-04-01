//Problem 5. 64 Bit array• Define a class  BitArray64  to hold  64  bit values inside an  ulong  value.
//• Implement  IEnumerable<int>  and  Equals(…) ,  GetHashCode() ,  [] ,  ==  and  != .

using System;

namespace Problem05
{
    class MainMethod
    {
        static void Main()
        {
            BitArray64 test = new BitArray64(123456789987654321);
            BitArray64 test1 = new BitArray64(123456789987654321);
            Console.WriteLine(Convert.ToString(123456789987654321, 2));

            Console.WriteLine(test[4]);
            Console.WriteLine(test[2]);
            Console.WriteLine(test.Equals(test1));
            Console.WriteLine(test.GetHashCode());
            Console.WriteLine(test1.GetHashCode());
            Console.WriteLine(test==test1); 
            Console.WriteLine(test != test1);
        }
    }
}
