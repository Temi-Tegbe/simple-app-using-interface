using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Phone
{
    class WiredPhones : IPhone
    {
        private string _manufacturer;
        private string _modelNumber;
        private bool _keypadPresent;

        public WiredPhones(string manufacturer, string modelNumber)
        {
            _manufacturer = manufacturer;
            _modelNumber = modelNumber;

        }

        public string Manufacturer
        {
            get => _manufacturer;

        }

        public string ModelNumber

        { 
            get => _modelNumber;

        }

        public bool KeypadPresent

        {
            get => _keypadPresent;
        }


        public void MakeCalls()

        {
            Console.WriteLine("I can make calls");
        }

        public void ReceiveCalls()

        {
            Console.WriteLine("I can receive calls");
        }

        //public void SendMessage()

        //{
        //    Console.WriteLine("I can send messages");
        //}

        //public void ReceiveMessages()

        //{
        //    Console.WriteLine("I can receive messages");
        //}


    }
}

