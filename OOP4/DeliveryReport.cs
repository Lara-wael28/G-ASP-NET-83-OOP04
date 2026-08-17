using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    public static class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance : {shipment.CalculateInsurance():F2} EGP");
        }
    }
}
