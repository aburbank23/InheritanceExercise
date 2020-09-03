using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal -
            // give this class 4 members that all Animals have in common -


            // Create a class Bird -
            // give this class 4 members that are specific to Bird -
            // Set this class to inherit from your Animal Class -

            // Create a class Reptile -
            // give this class 4 members that are specific to Reptile - 
            // Set this class to inherit from your Animal Class -




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var penguin = new Bird();
            penguin.BeakLength = 3.3;
            penguin.Color = "Black and White";
            penguin.HasFur = false;
            penguin.IsNocturnal = false;
            penguin.Land_Vs_Aquatic = "both";


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var kingSnake = new Reptile();
            kingSnake.ColdBloodedOrNot = true;
            kingSnake.Habitat = "Grasslands, forests, and rocky terrain";
            kingSnake.HasFur = false;
            kingSnake.Land_Vs_Aquatic = "Land";
            kingSnake.NumberOfLegs = 0;
            kingSnake.RegenerateTailOrNot = false;
            kingSnake.ScalesOrNot = true;
            kingSnake.Tail = true;

            penguin.PrintToConsole();
        }
    }
}
