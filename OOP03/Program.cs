using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1  Object Copying

            // a ) Both variables refer to the same object
            // b ) No. It only copies the reference
            // c )Reference copy: same object
            // Object copy: creates a new object
            #endregion

            #region Q2  Shallow Copy vs Deep Copy 
            // a ) Creates a new object, but reference-type members still point to the same objects
            // b ) Creates a new object with new copies of its reference-type members
            // c ) They share the same references
            // d ) They get new independent objects 
            // e ) When changing the copy must not affect the original
            #endregion
            #region Static Members
            // A ) field shared by all objects of the class
            // B ) A method belonging to the class, not an object ---- No, it cannot directly access instance members
            // C ) It initializes static members and runs automatically once
            // D ) A class that contains only static members ---- No, you cannot create an object from it
            #endregion
            #region Extension Methods 
            // a ) method that adds functionality to an existing class without modifying it
            // b ) The keyword this
            // c ) Inside a static class
            // d ) No, it can only access accessible members
            #endregion
            #region Partial Classes and Partial Methods
            // a ) class that is split into multiple files
            // b ) To organize the code and make it easier to manage
            // c ) A method whose declaration and implementation can be in different parts of the same partial class
            // d ) It is removed by the compiler and causes no error

            #endregion

            #endregion

            #region Part 2

            DeliveryUtilities.PrintSystemTitle();

            Console.WriteLine();
            Console.WriteLine("Creating Shipments...");
            DeliveryUtilities.PrintSeparator();

            int before = Shipment.GetTotalShipmentsCreated();

            Driver driver = new Driver();
            driver.DriverId = 1;
            driver.FullName = "Ahmed Mohamed";
            driver.PhoneNumber = "01012345678";

            DeliveryCenter center = new DeliveryCenter();
            center.CenterName = "Smart Delivery Center";
            center.Driver = driver;

            DeliveryAddress address1 =
                new DeliveryAddress("Cairo", "Nasr City", 10);

            DeliveryAddress address2 =
                new DeliveryAddress("Giza", "Dokki", 20);

            DeliveryAddress address3 =
                new DeliveryAddress("Alexandria", "Stanley", 30);

            StandardShipment standard = new StandardShipment(
                "S001",
                "Laptop",
                3m,
                50m,
                address1
            );

            Console.WriteLine("Standard Shipment Created");

            ExpressShipment express = new ExpressShipment(
                "S002",
                "Mobile Phone",
                2m,
                80m,
                address2,
                30m
            );

            Console.WriteLine("Express Shipment Created");

            InternationalShipmrnt international =
                new InternationalShipmrnt(
                    "S003",
                    "Refrigerator",
                    10m,
                    100m,
                    address3,
                    60m,
                    "Germany"
                );

            Console.WriteLine("International Shipment Created");

            Console.WriteLine();
            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            Console.WriteLine();
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Object Copying");
            DeliveryUtilities.PrintSeparator();

            Shipment assignedShipment = standard;

            Console.WriteLine();
            Console.WriteLine($"Original Shipment : {standard.TrackingCode}");
            Console.WriteLine($"Assigned Shipment : {assignedShipment.TrackingCode}");
            Console.WriteLine();
            Console.WriteLine($"Same Object : {ReferenceEquals(standard, assignedShipment)}");

            Console.WriteLine();
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Shallow Copy");
            DeliveryUtilities.PrintSeparator();

            Shipment shallowCopy = standard.ShallowCopy();

            Console.WriteLine();
            Console.WriteLine($"Original Shipment Address : {standard.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {shallowCopy.Destination.City}");

            Console.WriteLine();
            Console.WriteLine("Changing copied shipment address...");

            shallowCopy.Destination.City = "Giza";

            Console.WriteLine();
            Console.WriteLine($"Original Shipment Address : {standard.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {shallowCopy.Destination.City}");
            Console.WriteLine();
            Console.WriteLine(
                $"Same DeliveryAddress Object : {ReferenceEquals(standard.Destination, shallowCopy.Destination)}"
            );

            standard.Destination.City = "Cairo";

            Console.WriteLine();
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Deep Copy");
            DeliveryUtilities.PrintSeparator();

            Shipment deepCopy = standard.DeepCopy();

            Console.WriteLine();
            Console.WriteLine($"Original Shipment Address : {standard.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {deepCopy.Destination.City}");

            Console.WriteLine();
            Console.WriteLine("Changing copied shipment address...");

            deepCopy.Destination.City = "Giza";

            Console.WriteLine();
            Console.WriteLine($"Original Shipment Address : {standard.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {deepCopy.Destination.City}");
            Console.WriteLine();
            Console.WriteLine(
                $"Same DeliveryAddress Object : {ReferenceEquals(standard.Destination, deepCopy.Destination)}"
            );

            Console.WriteLine();
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Extension Methods");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine();
            Console.WriteLine(standard.GetSummary());
            Console.WriteLine(express.GetSummary());
            Console.WriteLine(international.GetSummary());

            Console.WriteLine();
            Console.WriteLine($"S001 Is Delivered : {standard.IsDelivered()}");
            Console.WriteLine($"S003 Is Delivered : {international.IsDelivered()}");

            Console.WriteLine();
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Tracking Status");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine();
            standard.UpdateTrackingStatus("Out For Delivery");

            Console.WriteLine();
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Static Utilities");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine();
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Delivery Center");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine();
            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            Console.WriteLine();
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Partial Method");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine();
            international.UpdateTrackingStatus("Delivered");

            Console.WriteLine();
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Assignment Completed");
            DeliveryUtilities.PrintSeparator();

            #endregion 
        }
    }
}
