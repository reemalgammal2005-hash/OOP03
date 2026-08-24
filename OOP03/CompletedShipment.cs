using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal sealed  class CompletedShipment :Shipment 
    {
        public CompletedShipment(string trackingCode)
        : base(trackingCode)
        {
        }

        public override decimal EstimatedCost => throw new NotImplementedException();

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }
    }
}
