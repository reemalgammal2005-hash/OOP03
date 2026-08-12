using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class Shipment
    {
        private string trackingcode;
        private string description;
        private decimal weight;
        private decimal deliveryfee;
        private DeliveryAddress destination;


        public string TrackingCode
        {
            get
            {
                return trackingcode;
            }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingcode = value;
                }
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }
        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }

        }
        public decimal DeliveryFee
        {
            get { return deliveryfee; }
            private set
            {
                if (value > 0)
                {
                    deliveryfee = value;
                }
            }
        }
        public DeliveryAddress Destination
        {
            get { return destination; }
            set
            {
                destination = value;
            }
        }
        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }


        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50M;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }
        public Shipment(string trackingcode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination)
        {
            TrackingCode = trackingcode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryfee;
            Destination = destination;

        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            DeliveryFee = newFee;
        }
        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Weight : {Weight}");
            Console.WriteLine($"Delivery Fee : {DeliveryFee}");
            Console.WriteLine($"Destination : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost}");
        }
        public void UpdateWeight(decimal newWeight)
        {
            Weight = newWeight;
        }
        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            Weight = newWeight + extraPackingWeight;
        }
    }
}
