using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class Driver
    {
        private int driverId;
        private string fullName;
        private string  phoneNumber;

        public int DriverId
        {
            get { return driverId; }
            set { driverId = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
