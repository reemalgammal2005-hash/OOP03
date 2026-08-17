using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class InternationalShipmrnt:Shipment ,ITrackable , IInsurable 
    {
        private decimal customsFee;
        private string destinationCountry;
        public InternationalShipmrnt(
            string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        decimal customsFee,
        string destinationCountry

            ) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            CustomsFee = customsFee;
            DestinationCountry = destinationCountry;
        }
        public decimal CustomsFee
        {
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }

            }
            get { return customsFee; }


        }
        public string DestinationCountry
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
            get
            {
                return destinationCountry;
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code        : {TrackingCode}");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost} EGP");
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Fee : {CustomsFee}");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }

    }
}
