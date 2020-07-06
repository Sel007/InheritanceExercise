using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
         //DONE - *Create an object of your Bird class and Reptile class
         //DONE - *  give values to your members using the object of your Bird class/Reptile class
         //*  
         //DONE - * Creatively display the class member values for each class
         //*/
            var blueJay = new Bird();
            blueJay.WingColor = "blue";
            blueJay.CanFly = true;
            blueJay.WillMigrate = true;
            blueJay.BeakLength = 3.5;

            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                CanGrowTail = true
            };

            //List<Animal> animals = new List<Animal>();
            //animals.Add(blueJay);
            //animals.Add(lizard);
            var myAnimals = new Animal[] { blueJay, lizard };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age} years old");
                Console.WriteLine($"It has: {animal.LegCount} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine($"");

            }    
                
        }
    }
}

// DONE - Be sure to follow best practice when creating your classes

// Create a class Animal
// give this class 4 members that all Animals have in common


// Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class

// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class
