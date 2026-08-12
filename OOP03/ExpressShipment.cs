using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class ExpressShipment:Shipment 
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
            base.PrintShipment();
            Console.WriteLine($"Extra Fee : {ExtraFee}");
        }
    }
}
