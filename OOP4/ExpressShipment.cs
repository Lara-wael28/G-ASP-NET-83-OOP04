using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    public class ExpressShipment : Shipment , ITrackable, IInsurable
    {
        private decimal ExtraFee;

        public decimal extraFee
        {
            get { return ExtraFee; }
            set
            {
                if (value >= 0)
                    ExtraFee = value;
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return deliveryFee + (weight * 5) + ExtraFee;
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {trackingCode}");
            Console.WriteLine($"Description : {description}");
            Console.WriteLine($"Weight : {weight} KG");
            Console.WriteLine($"Delivery Fee : {deliveryFee} EGP");
            Console.WriteLine($"Extra Fee : {extraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus()
        {
            return ($"Shipment {trackingCode} is Out for Delivery.");
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
    }
}
