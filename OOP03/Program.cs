namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1 Abstraction

            //A) Abstraction is the process of hiding implementation details and showing only the essential features of an object
            //B)Because it reduces complexity, improves maintainability, enhances security, and promotes flexibility & reusability
            #endregion

            #region Q2 Abstract Classes vs. Interfaces
            /* a) Abstract Class can contain both abstract methods and concrete methods
             * Interface mainly defines a contract that classes must implement, and a class can implement multiple interface
             */
            // b)When I want to define a common behavior for unrelated classes, achieve loose coupling, or support multiple inheritance of type
            /* c) No=> a class can inherit from only one abstract class
             * Yes => a class can implement multiple interfaces
             * 
             */
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
