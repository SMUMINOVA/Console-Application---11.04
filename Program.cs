using System;

namespace HW11._04
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("How many cas do you have in your salon?");
            int numb = int.Parse(Console.ReadLine());
            System.Console.WriteLine("What kind of car do you have in your salon?");
            Avto [] cars = new Avto [numb];
            for (int i = 0; i < numb; i++){
                cars[i] = new Avto();
                System.Console.Write("Enter name of the car: ");
                cars[i].nameOfModel = Console.ReadLine();
                System.Console.Write("Enter year of issue: ");
                cars[i].yearOfIssue = int.Parse(Console.ReadLine());
                System.Console.Write("Enter max speed of car: ");
                cars[i].maxSpeed = int.Parse(Console.ReadLine());
                System.Console.Write("Enter price of car: ");
                cars[i].priceOfCar = int.Parse(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Your collection:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach(var m in cars)
            m.showInfo();
            Console.ReadKey();
        }
        class Avto{
            public string nameOfModel{get; set;}
            public int yearOfIssue{get; set;}
            public int maxSpeed{get; set;}
            public int priceOfCar{get; set;}
            public void showInfo(){
                System.Console.WriteLine($"The name of car: {nameOfModel}\nThe year of issue: {yearOfIssue}\nMax speed: {maxSpeed}\nPrice: {priceOfCar}");
            }
        }
    }
}
