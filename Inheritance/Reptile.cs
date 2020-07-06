using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "Land and Sea";
            Age = 4;
        }

        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }
    }
}

// DONE - Create a class Reptile
// DONE - Give this class 4 members that are specific to Reptile
// DONE - Set this class to inherit from your Animal Class


