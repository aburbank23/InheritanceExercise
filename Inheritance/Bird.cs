using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            NumberOfLegs = 2;
            Tail = false;
            Wings = true;
        }

        public bool Wings { get; set; }
        public double BeakLength { get; set; }
        public bool IsNocturnal { get; set; }
        public string Color { get; set; }

        public void PrintToConsole()
        {
            Console.WriteLine($"Penguin Characteristics");
            Console.WriteLine();
            Console.WriteLine($"Beak Length: {BeakLength}");
            Console.WriteLine($"Color: { Color}");
            Console.WriteLine($"Has Fur: {HasFur}");
            Console.WriteLine($"Nocturnal: {IsNocturnal}");
            Console.WriteLine($"Lives on Land or Sea: {Land_Vs_Aquatic}");            
        }

    }
}
