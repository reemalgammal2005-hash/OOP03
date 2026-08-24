using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal abstract partial class Shipment
    {
        private string trackingcode;
        private string description;
        private decimal weight;
        private decimal deliveryfee;
        private DeliveryAddress destination;
        public static int TotalShipmentsCreated = 0;
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }


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
        public abstract decimal EstimatedCost { get; }


        public Shipment(string trackingCode)
        {
            TotalShipmentsCreated++;

            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50M;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }
        public Shipment(
    string trackingcode,
    string description,
    decimal weight,
    decimal deliveryfee,
    DeliveryAddress destination)
        {
            TotalShipmentsCreated++;

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
        public abstract void PrintShipment();
        public void UpdateWeight(decimal newWeight)
        {
            Weight = newWeight;
        }
        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            Weight = newWeight + extraPackingWeight;
        }
        public Shipment CopyShipment()
        {
            return (Shipment)this.MemberwiseClone();
        }
        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();

            copy.Destination = new DeliveryAddress(
                this.Destination.City,
                this.Destination.Street,
                this.Destination.BuildingNumber
            );

            return copy;
        }
        
    }
}
