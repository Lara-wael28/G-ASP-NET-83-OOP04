
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    public class PriorityInternationalShipment : InternationalShipment
    {

        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base( trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {

        }
        public override sealed void GenerateCustomsReport()
        {
            Console.WriteLine("Priority Customs Report Generated.");
        }
    }
}
