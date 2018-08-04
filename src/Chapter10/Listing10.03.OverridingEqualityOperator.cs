using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_03
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_06;

    public class Program
    {
        public static void Main()
        {
            ProductSerialNumber serialNumber1 =
                new ProductSerialNumber("PV", 1000, 09187234);
            ProductSerialNumber serialNumber2 = serialNumber1;
            ProductSerialNumber serialNumber3 =
                new ProductSerialNumber("PV", 1000, 09187234);

            // These serial numbers ARE the same object identity
            if(!ProductSerialNumber.ReferenceEquals(serialNumber1,
                serialNumber2))
            {
                throw new Exception(
                    "serialNumber1 does NOT " +
                    "reference equal serialNumber2");
            }
            // And, therefore, they are equal
            else if(!serialNumber1.Equals(serialNumber2))
            {
                throw new Exception(
                    "serialNumber1 does NOT equal serialNumber2");
            }
            else
            {
                Console.WriteLine(
                    "serialNumber1 reference equals serialNumber2");
                Console.WriteLine(
                    "serialNumber1 equals serialNumber2");
            }


            // These serial numbers are NOT the same object identity
            if(ProductSerialNumber.ReferenceEquals(serialNumber1,
                    serialNumber3))
            {
                throw new Exception(
                    "serialNumber1 DOES reference " +
                    "equal serialNumber3");
            }
            // But they are equal (assuming Equals is overloaded)
            else if(!serialNumber1.Equals(serialNumber3) ||
                serialNumber1 != serialNumber3)
            {
                throw new Exception(
                    "serialNumber1 does NOT equal serialNumber3");
            }

            Console.WriteLine("serialNumber1 equals serialNumber3");
        }
    }
}