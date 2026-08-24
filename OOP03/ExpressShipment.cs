using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class ExpressShipment:Shipment , ITrackable , IInsurable 
    {
        private decimal extraFee;
        public ExpressShipment(
            string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        decimal extrafee
            ) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }

            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + extraFee;
            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}
