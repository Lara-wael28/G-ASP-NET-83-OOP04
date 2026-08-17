using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    public class DeliveryCenter
    {
        private Shipment[] shipments;
        private string centerName;
        public string CenterName { get; set; }
        public Driver Driver { get; set; }

        public DeliveryCenter(string centerName)
        {
            this.centerName = centerName;
            shipments = new Shipment[20];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }

        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null && shipments[i].trackingCode == trackingCode)
                        return shipments[i];
                }
                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null || shipments[i].trackingCode == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].trackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }
        public void PrintAllShipments()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            if (Driver != null)
            {
                Console.WriteLine($"Driver : {Driver.DriverName}");
            }
            Console.WriteLine("------------------------------------------");
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();

                    Console.WriteLine("------------------------------------------");
                }
            }
        }
        public void PrintTrackingStatuses()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("==========================================");

            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    ITrackable trackable = (ITrackable)shipment;

                    Console.WriteLine(
                        trackable.GetTrackingStatus()
                    );
                }
            }
        }

    }
}
    
