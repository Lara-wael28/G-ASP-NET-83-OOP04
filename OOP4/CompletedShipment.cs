
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

        public override decimal EstimatedCost {
            get
            {
                return deliveryFee + (weight * 5);
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment");
            Console.WriteLine($"Tracking Code : {trackingCode}");
            Console.WriteLine($"Description : {description}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }
        
    }
}
