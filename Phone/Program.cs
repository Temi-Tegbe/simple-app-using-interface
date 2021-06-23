using System;

namespace Phone
{



    class Program
    {
        static void Main(string[] args)
        {
            Smartphones newPhone = new Smartphones("Xioami", "Redmi 7", 1234567891011213, false);

            Console.WriteLine(newPhone.Manufacturer);
            Console.WriteLine(newPhone.ModelNumber);
            Console.WriteLine(newPhone.IMEI);
            Console.WriteLine(newPhone.KeypadPresent);

        }

        
        
        
    }
}

