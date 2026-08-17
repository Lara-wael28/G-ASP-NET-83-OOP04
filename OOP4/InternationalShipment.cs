using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string DestinationCountry;
        private decimal CustomsFee;

        public string destinationCountry
        {
            get { return DestinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    DestinationCountry = value;
            }
        }

        public decimal customsFee
        {
            get { return CustomsFee; }
            set {
                if (value >= 0)
                    CustomsFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return deliveryFee + (weight * 5) + CustomsFee;
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code : {trackingCode}");
            Console.WriteLine($"Description : {description}");
            Console.WriteLine($"Weight : {weight} KG");
            Console.WriteLine($"Delivery Fee : {deliveryFee} EGP");
            Console.WriteLine($"Destination Country : {destinationCountry}");
            Console.WriteLine($"Customs Fee : {customsFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Customs Report Generated.");
        }

        public string GetTrackingStatus()
        {
            return ($"Shipment {trackingCode} has been Delivered.");
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
    }
}
