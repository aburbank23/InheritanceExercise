using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }

        public string Habitat { get; set; }
        public bool ScalesOrNot { get; set; }
        public bool ColdBloodedOrNot { get; set; }
        public bool RegenerateTailOrNot { get; set; }

    }
}
