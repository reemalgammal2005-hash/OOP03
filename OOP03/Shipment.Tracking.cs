using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal abstract partial class Shipment
    {
        private string trackingStatus;

        public string TrackingStatus
        {
            get
            {
                return trackingStatus;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingStatus = value;
                }
            }
        }

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            TrackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }

        partial void OnTrackingStatusChanged(string newStatus);

    }
}
