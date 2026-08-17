using System;
namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region question1
            //a)Abstraction is the process of hiding unnecessary implementation details and showing only the essential features of an object to the user.
            //b) because it helps us:
            //    Hide complex implementation details.
            //    Show only the important functionality.
            //    Reduce complexity.
            //    Make code easier to understand and maintain.
            //    focus on what an object does rather than how it does it.
            #endregion

            #region question2
            //a)Interface:A class can implement multiple interfaces ,Used when different classes need to follow the same behavior/contract. ,Interface members are generally public 
            // Abstract Class: A class can inherit from only one abstract/base class , Used when classes have a common base and shared implementation. , Can have access modifiers for its members.

            // b)choose an Interface when you want different and potentially unrelated classes to share the same behavior or contract.
            //c)No, a C# class cannot inherit from multiple classes, whether they are abstract or not , But a class can implement multiple interfaces

            #endregion

            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(centerName);
            center.CenterName = centerName;

            Console.WriteLine("\n--- Driver Information ---");

            Console.Write("Driver ID: ");
            int driverId = int.Parse(Console.ReadLine());

            Console.Write("Driver Full Name: ");
            string driverName = Console.ReadLine();

            Console.Write("Driver Phone Number: ");
            string driverPhone = Console.ReadLine();

            Driver driver = new Driver( driverId, driverName, driverPhone);
            center.Driver = driver;

            Console.WriteLine("--- Standard Shipment ---");
            Console.Write("Tracking Code: ");
            string trackingCode1 = Console.ReadLine();
            Console.Write("Description: ");
            string description1 = Console.ReadLine();
            Console.Write("Weight: ");
            decimal weight1 = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal deliveryFee1 = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city1 = Console.ReadLine();
            Console.Write("Street: ");
            string street1 = Console.ReadLine();
            Console.Write("Building Number: ");
            int buildingNumber1 = int.Parse(Console.ReadLine());
            DeliveryAddress destination1 = new DeliveryAddress(city1, street1, buildingNumber1);

            StandardShipment standard = new StandardShipment(trackingCode1, description1, weight1, deliveryFee1, destination1);

            Console.WriteLine("--- Express Shipment ---");
            Console.Write("Tracking Code: ");
            string trackingCode2 = Console.ReadLine();
            Console.Write("Description: ");
            string description2 = Console.ReadLine();
            Console.Write("Weight: ");
            decimal weight2 = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal deliveryFee2 = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city2 = Console.ReadLine();
            Console.Write("Street: ");
            string street2 = Console.ReadLine();
            Console.Write("Building Number: ");
            int buildingNumber2 = int.Parse(Console.ReadLine());
            DeliveryAddress destination2 = new DeliveryAddress(city2, street2, buildingNumber2);
            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            ExpressShipment express = new ExpressShipment(trackingCode2, description2, weight2, deliveryFee2, destination2, extraFee);

            Console.WriteLine("\n--- International Shipment ---");
            Console.Write("Tracking Code: ");
            string trackingCode3 = Console.ReadLine();
            Console.Write("Description: ");
            string description3 = Console.ReadLine();
            Console.Write("Weight: ");
            decimal weight3 = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal deliveryFee3 = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city3 = Console.ReadLine();
            Console.Write("Street: ");
            string street3 = Console.ReadLine();
            Console.Write("Building Number: ");
            int buildingNumber3 = int.Parse(Console.ReadLine());
            DeliveryAddress destination3 = new DeliveryAddress(city3, street3, buildingNumber3);
            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();
            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            InternationalShipment international = new InternationalShipment(trackingCode3, description3, weight3, deliveryFee3, destination3, destinationCountry, customsFee);

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);
            center.PrintAllShipments();

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Printing Using DeliveryHelper ");
            Console.WriteLine("==========================================");
            DeliveryHelper.PrintShipmentDetails(standard);
            Console.WriteLine();
            DeliveryHelper.PrintShipmentDetails(express);
            Console.WriteLine();
            DeliveryHelper.PrintShipmentDetails(international);
            Console.WriteLine();

            Console.WriteLine("==========================================");
            Console.WriteLine("Updating Weight...");
            Console.WriteLine("==========================================");

            Console.WriteLine($"Original Weight : {standard.weight} KG");
            standard.UpdateWeight(5);

            Console.WriteLine($"Updated Weight : {standard.weight} KG");
            standard.UpdateWeight(5, 0.5m);

            Console.WriteLine( $"Updated Weight After Packing : {standard.weight} KG");


            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Printing Using Shipment[]...");
            Console.WriteLine("==========================================");

            Shipment[] shipments = {standard,express,international};

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Sealed Method Demonstration");
            Console.WriteLine("==========================================");

            PriorityInternationalShipment priority =new PriorityInternationalShipment(
                    "SH005",
                    "Camera",
                    4,
                    150,
                    destination2,
                    "France",
                    120 );
            priority.GenerateCustomsReport();

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Statuses");
            Console.WriteLine("==========================================");
            center.PrintTrackingStatuses();

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("ITrackable[] Demonstration");
            Console.WriteLine("==========================================");

            ITrackable[] trackableShipments =
            {
                standard,
                express,
                international 
            };

            foreach (ITrackable shipment in trackableShipments)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("IInsurable[] Demonstration");
            Console.WriteLine("==========================================");

            IInsurable[] insurableShipments =
            {
                standard,
                express,
                international
            }; 

            foreach (IInsurable shipment in insurableShipments)
            {
                Console.WriteLine($"Insurance : {shipment.CalculateInsurance():F2} EGP");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Report");
            Console.WriteLine("==========================================");

            Console.WriteLine("\n--- Standard Shipment ---");
            DeliveryReport.PrintShipment(standard);
            DeliveryReport.PrintInsurance(standard);

            Console.WriteLine("\n--- Express Shipment ---");
            DeliveryReport.PrintShipment(express);
            DeliveryReport.PrintInsurance(express);

            Console.WriteLine("\n--- International Shipment ---");
            DeliveryReport.PrintShipment(international);
            DeliveryReport.PrintInsurance(international);


            Console.Write("\nEnter tracking code to search: ");
            string searchCode = Console.ReadLine();
            Shipment found = center[searchCode];
            if (found != null)
            {
                Console.WriteLine("\nShipment Found:");
                found.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            Console.Write("\nEnter tracking code to remove: ");
            string removeCode = Console.ReadLine();
            bool removed = center.RemoveShipment(removeCode);
            Console.WriteLine(removed ? "Shipment removed successfully." : "Shipment not found for removal.");
            Console.WriteLine("\n--- Remaining Shipments ---");
            center.PrintAllShipments();

            
        }
        }
    }
