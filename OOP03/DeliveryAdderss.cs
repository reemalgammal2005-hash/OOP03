using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class DeliveryAddress
    {
        private string city;
        private string street;
        private int buildingNumber;

        public DeliveryAddress(string City, string Street, int BuildingNumber)
        {
            city = City;
            street = Street;
            buildingNumber = BuildingNumber;
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int BuildingNumber
        {
            get { return buildingNumber; }
            set { buildingNumber = value; }
        }


        public string GetFullAddress()
        {
            return $"City :{City} \n Street : {Street} \n BuildingNumber :{BuildingNumber}";
        }

    }
}
