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
              
                Console.WriteLine("==========================");

                center.PrintAllShipments();

                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine("Tracking Status");
                Console.WriteLine("==========================");

                center.PrintTrackingStatuses();

                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine("Insurance");
                Console.WriteLine("==========================");

                center.PrintInsuranceCosts();

                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine("ITrackable Array");
                Console.WriteLine("==========================");

                ITrackable[] trackables =
                {
                standard,
                express,
                international
            };

                foreach (ITrackable t in trackables)
                {
                    Console.WriteLine(t.GetTrackingStatus());
                }

                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine("IInsurable Array");
                Console.WriteLine("==========================");

                IInsurable[] insurables =
                {
                standard,
                express,
                international
            };

                foreach (IInsurable i in insurables)
                {
                    Console.WriteLine(i.CalculateInsurance());
                }

                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
            #endregion 
        }
    }
    }

