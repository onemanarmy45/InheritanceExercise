using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var woodpecker = new Bird();
            woodpecker.CareForYoung = true;
            woodpecker.BeakLength = 4.3;
            woodpecker.Migratory = true;
            woodpecker.Monogamous = false;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var rattlesnake = new Reptile();
            rattlesnake.HeartChambers = 3;
            rattlesnake.IsScaly = true;
            rattlesnake.Habitat = "rocks";
            rattlesnake.TailRegeneration = false;

            var misAnimales = new Animal[] { woodpecker, rattlesnake };

            foreach( var animal in misAnimales)
            {
                Console.WriteLine($"Legs: {animal.LegCount}");
                Console.WriteLine($"Mammalian? {animal.IsMammal}");
                Console.WriteLine($"Diet? {animal.Diet}");
                Console.WriteLine($"Amphibious? {animal.Amphibious}");
                Console.WriteLine("");
            }
        }
    }
}