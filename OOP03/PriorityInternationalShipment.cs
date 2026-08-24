using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class PriorityInternationalShipment : InternationalShipmrnt 
    {
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Priority Customs Report");
        }
        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee,
            DeliveryAddress destination, decimal customsFee, string destinationCountry) : base(trackingCode ,description ,weight,
                deliveryFee ,destination ,customsFee ,destinationCountry)
        {

        }
        
  
    

    }
}
