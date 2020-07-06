using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            LegCount = 2;
            LandSeaAir = "Air";
            Age = 2;
        }
        public string WingColor { get; set; }
        public bool CanFly { get; set; }
        public bool WillMigrate { get; set; }
        public double BeakLength { get; set; }
        
    }


}

// DONE - Create a class Bird
// DONE - Give this class 4 members that are specific to Bird
// DONE - Set this class to inherit from your Animal Class

