using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    public struct DeliveryAddress
    {
        public string city;
        public string street;
        public int BuildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            this.BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{BuildingNumber} {street} Street, {city}";
        }
    }

    public class Customer
    {
        public string name;
    }
} 
    
