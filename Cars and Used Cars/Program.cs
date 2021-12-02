using System;
using System.Collections.Generic;

namespace Cars_and_Used_Cars
{
    class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public decimal Price;

        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }
        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }

        public static List<Car> Cars = new List<Car>();

        public override string ToString()
        {
            return $"{Make,-12}{Model,-18}{Year,-9}{Price,-12}";
        }
        public static void ListCars()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}.   {Cars[i].ToString()}");
            }
        }
        public static void Remove(int index)
        {
            Cars.RemoveAt(index);
        }

        public static void Add(Car car)
        {
            Cars.Add(car);
        }
    }
    class UsedCar : Car
    {
        private double Milage;

        public UsedCar() : base("", "", 0, 0)
        {
            Milage = 0;
        }
        public UsedCar(double Milage, string Make, string Model, int Year, decimal Price) : base(Make, Model, Year, Price)
        {
            this.Milage = Milage;
        }

        public override string ToString()
        {
            return $"{Make,-12}{Model,-18}{Year,-9}{Price,-12}{Milage,-12}";
        }
    }
    class Program
    {
        static void AddCarToList()
        {
            bool used = true;
            string make = "";
            string model = "";
            int year = 0;
            decimal price = 0;
            double milage = 0;

            Console.Write("Is the car you are adding used? (y/n) ");

            bool validInput = false;
            do
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    validInput = true;
                    used = true;
                }
                else if (input.ToLower() == "n")
                {
                    validInput = true;
                    used = false;
                }
                else
                {
                    Console.Write("Is the car you are adding used? (y/n) ");
                }
            } while (!validInput);

            Console.Write("Please enter the Make of the car you are adding: ");
            make = Console.ReadLine();

            Console.Write("Please enter the Model of the car you are adding: ");
            model = Console.ReadLine();

            Console.Write("Please enter the year of the car you are adding: ");
            validInput = false;
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out year))
                {
                    validInput = true;
                }
                else
                {
                    Console.Write("Please enter the year of the car you are adding: ");
                }
            } while (!validInput);

            Console.Write("Please enter the price of the car you are adding: ");
            validInput = false;
            do
            {
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out price))
                {
                    validInput = true;
                }
                else
                {
                    Console.Write("Please enter the price of the car you are adding: ");
                }
            } while (!validInput);

            if (used)
            {
                Console.Write("Please enter the milage of the car you are adding: ");
                validInput = false;
                do
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out milage))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.Write("Please enter the price of the car you are adding: ");
                    }
                } while (!validInput);
            }

            if (used)
            {
                Car.Add(new UsedCar(milage, make, model, year, price));
            }
            else
            {
                Car.Add(new Car(make, model, year, price));
            }

            Console.WriteLine("Car added!");
        }
        static void Main(string[] args)
        {
            Car.Cars.Add(new UsedCar(30204.1, "Honda", "Accord", 2012, 11990m));
            Car.Cars.Add(new UsedCar(54095.9, "Ford", "Crown Victoria", 2007, 12310m));
            Car.Cars.Add(new UsedCar(57108.7, "BMW", "6 Series", 2017, 22995m));
            Car.Cars.Add(new Car("Honda", "Civic", 2022, 21900m));
            Car.Cars.Add(new Car("Ford", "F-150", 2022, 29640m));
            Car.Cars.Add(new Car("BMW", "i8", 2020, 147500m));

            Console.WriteLine("Here's our inventory!\n");

            Console.WriteLine($"     {"Make",-12}{"Model",-18}{"Year",-9}{"Price",-12}{"Milage",-12}\n");

            Car.ListCars();

            Console.Write("\nPlease enter the number of the car you would like to purchase: ");

            bool validInput = false;
            int carChoice;
            string input;
            do
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out carChoice) && carChoice > 0 && carChoice <= Car.Cars.Count)
                {
                    validInput = true;
                }
                else
                {
                    Console.Write("Please enter the number of the car you would like to purchase: ");
                }
            } while (!validInput);

            Console.WriteLine("\nHere is the car you chose:\n");
            Console.WriteLine($"{carChoice}.   {Car.Cars[carChoice - 1].ToString()}");
            Car.Remove(carChoice - 1);
            Console.WriteLine("\nHeres the updated cars list:\n");
            Car.ListCars();
            AddCarToList();
            Car.ListCars();
        }
    }
}
