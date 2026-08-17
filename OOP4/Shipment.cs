using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    public abstract class Shipment
    {
            private string TrackingCode;
            private string Description;
            private decimal Weight;
            private decimal DeliveryFee;
            private DeliveryAddress destination; 
            public DeliveryAddress Destination { get; set; }

            public string trackingCode
            {
                get { return TrackingCode; }
                private set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        TrackingCode = value;
                }
            }

            public string description
            {
                get { return Description; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        Description = value;
                }
            }

            public decimal weight
            {
                get { return Weight; }
                set
                {
                    if (value > 0)
                        Weight = value;
                }
            }

            public decimal deliveryFee
            {
                get { return DeliveryFee; }
                private set
                {
                    if (value > 0)
                        DeliveryFee = value;
                }
            }
           public abstract decimal EstimatedCost { get; }
            

            public Shipment(string trackingCode)
            {
                this.trackingCode = trackingCode;
                Description = "Unknown";
                Weight = 1;
                DeliveryFee = 50;
                Destination = new DeliveryAddress("Unknown", "Unknown", 0);
            }

            public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            {
                this.trackingCode = trackingCode;
                this.description = description;
                this.weight = weight;
                this.deliveryFee = deliveryFee;
                Destination = destination;

            }
            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                    DeliveryFee = newFee;
            }

            public void UpdateWeight(decimal newWeight)
            {
                if (newWeight > 0)
                    Weight = newWeight;
            }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight >= 0)
                Weight = newWeight + extraPackingWeight;
        }

        public abstract void PrintShipment();
                
        }
    }

