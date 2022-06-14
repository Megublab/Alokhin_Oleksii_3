using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LAb
{
    public class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Car(string Name , string Color)
        {
            this.Name = Name;
            this.Color = Color;
        }
        public static string GetMark()
        {
            string[] str = {"Opel","Nisan","BMW","Lexus","Ford"};
            Random run = new Random();
            return str[run.Next(0,str.Length)];
        }
        public static string GetColor()
        {
            string[] str2 = { "Black", "Blue", "Red", "Yellow", "White" };
            Random run = new Random();
            return str2[run.Next(0, str2.Length)];
        }
        public static void GetDrive(bool engine, double fuel , double coef , int wheel)
        {
            if(engine == false)
            {
                Console.WriteLine("Starting Engine");
                Thread.Sleep(200);
                Console.WriteLine("...");
                Thread.Sleep(200);
                Console.WriteLine("Engine Ready!");
                Thread.Sleep(400);
                Car.GetWheelChange(wheel);
                Console.WriteLine($"Car complete {fuel/coef}km");
                Car.GetFuel();
            }
            else
            {
                Console.WriteLine("Engine Ready!");
                Thread.Sleep(400);
                Car.GetWheelChange(wheel);
                Console.WriteLine($"Car complete {fuel / coef}km");
                Car.GetFuel();
            }

        }
        public static void GetFuel()
        {
            Console.WriteLine("Wanna fuel ?");
            string s = Console.ReadLine();
            if(s.ToLower() == "yes")
            {
                Console.WriteLine("Enter fuel (coef 0.1)");
                double fuel = int.Parse(Console.ReadLine());
                Car.GetDrive(true, fuel, 0.1, 0);
            }
            else if (s.ToLower() == "no")
            {
                Console.WriteLine("End of drive ");
            }
            else
            {
                Console.WriteLine("Unknown command");
            }
        }
        public static void GetWheelChange(int number)
        {
            Random run = new Random();
            if(run.Next(0,100) < 5)
            {
                Console.WriteLine("Oh no... Wheel brocken");
                Console.WriteLine("Repearing...");
                Thread.Sleep(200);
                Console.WriteLine("...");
                Thread.Sleep(200);
                Console.WriteLine($"Wheel Repaired , wheel number: {number+1}");
            }
            else
            {
                Console.WriteLine("Drive finished");
            }
        }
        public override string ToString()
        {
            Car car = new Car(GetMark(),GetColor());
            string s = string.Format($"Car Mark: {car.Name} , {car.Name} has {car.Color} color");
            return s;
        }
    }
    public class Wheel
    {
        public bool damage;
        public int wheel;
        public Wheel(bool damage , int wheel)
        {
            this.damage = damage;
            this.wheel = wheel;
        }
    }
    public class Engine
    {
        public bool status;
        public double fuel_cof;
        public double fuel;
        public Engine(bool status , double fuel , double fuel_cof)
        {
            this.status = status;
            this.fuel = fuel;
            this.fuel_cof = fuel_cof;
        }

    }
}
