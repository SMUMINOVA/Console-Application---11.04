using System;

namespace HW11._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
