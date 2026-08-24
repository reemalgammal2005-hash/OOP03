using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal  static  class ShipmentExtensions
    {

        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | {shipment.GetType().Name.Replace("Shipment", "")} | {shipment.Weight} KG | In Transit";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            ITrackable trackable = (ITrackable)shipment;
            return trackable.GetTrackingStatus().Contains("Delivered");
        }

    }
}
