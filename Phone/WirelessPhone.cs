using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Phone
{
    class WirelessPhone : IPhone
    {
        private string _manufacturer;
        private string _modelNumber;
        private bool _keypadPresent;
        private int _imei;

        public WirelessPhone(string manufacturer, string modelNumber, int imei)
        {
            _manufacturer = manufacturer;
            _modelNumber = modelNumber;
            _imei = imei;

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

        public int IMEI
        {
            get => _imei;
        }


        public void MakeCalls()

        {
            Console.WriteLine("I can make calls");
        }

        public void ReceiveCalls()

        {
            Console.WriteLine("I can receive calls");
        }

        public void SendMessage()

        {
            Console.WriteLine("I can send messages");
        }

        public void ReceiveMessages()

        {
            Console.WriteLine("I can receive messages");
        }


    }
}

