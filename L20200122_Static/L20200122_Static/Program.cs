using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20200122_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Car details :");
            Car.Counter = 0;
            Car car = new Car();
            while (Car.SetCounter())
            {
                Console.WriteLine("Please enter Car model :");
                car.SetModel(Console.ReadLine());
                Console.WriteLine("Please enter Car speed :");

                car.SetCurrentSpeed(int.Parse(Console.ReadLine()));
                Car.Counter += 1;

            }

            Console.ReadLine();
        }



        //Targil 1 : avoid created more than 10 objects of the same class.


        public class Car
        {
            public string PlateNumber;
            public string Color;
            public string Manufacturer;
            public bool EBS;
            public static int Counter { get; set; } 


            int currentSpeed;
            string Model;

            //public Car() : this(10)
            //{

            //}
            //public Car(int initialSpeed) : this(initialSpeed, "TT") { }


            public Car(int initialSpeed = 10, string model = "TT")
            {
                SetModel(model);
                SetCurrentSpeed(initialSpeed);
                SetCounter();
            }
            public static bool SetCounter() {
                if (Counter >= 10)
                {
                    Console.WriteLine($"You Exceeded the creation of { Counter } Objects");
                    return false;
                }
                else
                {
                    Console.WriteLine($"You need to choose another { 10 - Counter }");
                    return true;
                }
            }

            public void PrintCar()
            {
                //Console.WriteLine(
                //    "PlateNumber : {0}, Color: {1}, Speedometer : {2}, Manufacturer: {3}, Model: {4}, EBS Exists ? {5}", PlateNumber, Color, currentSpeed, Manufacturer, Model, EBS
                //    );

                Console.WriteLine("Model: {0}, Speedometer : {1}", Model, currentSpeed);

            }
            public void SpeedUp(int delta)
            {
                currentSpeed += delta;
            }

            //Setter
            public void SetModel(string m)
            {
                this.Model = m; //this is the pointer to the current object created/
            }
            public void SetCurrentSpeed(int s)
            {
                if (s <= 0)
                    return;
                currentSpeed = s;
            }
            //Getter
            public string GetModel()
            {
                return Model;
            }
            public int GetCurrentSpeed()
            {
                return currentSpeed;
            }

        }

    }
}
