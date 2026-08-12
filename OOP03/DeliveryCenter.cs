using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class DeliveryCenter
    {
        private string centerName;

        private Shipment[] shipments = new Shipment[20];
        private int count;

        public bool AddShipment(Shipment shipment)
        {
            if (count < 20)
            {
                shipments[count] = shipment;
                count++;
                return true;
            }

            return false;
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return shipments[index];
                }

                return null;
            }

            set
            {
                if (index >= 0 && index < count)
                {
                    shipments[index] = value;
                }
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }
        public string CenterName
        {
            get
            {
                return centerName;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    centerName = value;
                }
            }
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < count; i++)
            {
                if (shipments[i].TrackingCode == trackingCode)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }


                    shipments[count - 1] = null;


                    count--;

                    return true;
                }
            }

            return false;
        }
        public void PrintAllShipments()
        {
            if (count == 0)
            {
                Console.WriteLine("No shipments found.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                shipments[i].PrintShipment();
                Console.WriteLine("----------------------------");
            }
        }
        public Driver Driver { get; set; }
    }
}
