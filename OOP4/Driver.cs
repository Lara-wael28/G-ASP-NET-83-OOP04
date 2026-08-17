using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    public class Driver
    {
        public int DriverID { get; set; }
        public string DriverName { get; set; }
        public string PhoneNumber { get; set; }
        public Driver(int driverID, string driverName, string phoneNumber)
        {
            DriverID = driverID;
            DriverName = driverName;
            PhoneNumber = phoneNumber;
        }
    }
}
