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


              
                ExpressShipment express = new ExpressShipment(
                    "S002",
                    "Mobile Phone",
                    2m,
                    80m,
                    address2,
                    30m
                );


                
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


                center.AddShipment(standard);
                center.AddShipment(express);
                center.AddShipment(international);


               
                Console.WriteLine("Delivery Center");
                Console.WriteLine("==========================");

                Console.WriteLine($"Center : {center.CenterName}");
                Console.WriteLine("==========================");

                center.PrintAllShipments();


                Console.WriteLine();
                Console.WriteLine("Printing using polymorphism...");
                Console.WriteLine("==========================");

                DeliveryHelper.PrintShipmentDetails(standard);

                Console.WriteLine();

                DeliveryHelper.PrintShipmentDetails(express);

                Console.WriteLine();

                DeliveryHelper.PrintShipmentDetails(international);


                
                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine("Tracking weights...");

                Console.WriteLine($"Original weight : {standard.Weight} kg");

                
                standard.UpdateWeight(5m);

                Console.WriteLine($"Updated weight : {standard.Weight} kg");

                standard.UpdateWeight(5m, 0.5m);

                Console.WriteLine(
                    $"Updated weight after packing : {standard.Weight} kg"
                );


               
                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine("Tracking using Shipment[]...");

                Shipment[] shipments =
                {
                standard,
                express,
                international
            };

                foreach (Shipment shipment in shipments)
                {
                    shipment.PrintShipment();
                    Console.WriteLine("--------------------------");
                }
            }
            #endregion
        }
    }

