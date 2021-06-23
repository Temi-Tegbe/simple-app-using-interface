using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Phone
{
    class Smartphones : IPhone
    {
        private string _manufacturer;
        private string _modelNumber;
        private bool _keypadPresent;
        private long _imei;

        public Smartphones(string manufacturer, string modelNumber, long imei, bool keypadPresent)
        {
            _manufacturer = manufacturer;
            _modelNumber = modelNumber;
            _imei = imei;
            _keypadPresent = keypadPresent;

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

        public long IMEI
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

        public void SurfInternet()
        {
            Console.WriteLine("I can surf the net");
        }

        public void  SendEmail()
        {
            Console.WriteLine("I can send emails");

        }

        public void ReceiveEmail()
        {
            Console.WriteLine("I can receive emails");
        }

        public void UseWebBasedApplications()
        {
            Console.WriteLine("I can use web-based applications");
        }


    }
}

