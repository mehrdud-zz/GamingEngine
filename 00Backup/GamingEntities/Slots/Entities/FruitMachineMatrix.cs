using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamingEntities.Slots.Entities
{
    
    class FruitMachineMatrix
    {
        public int VerticalSize { get; set; }
        public int HorizontalSize { get; set; }

        public FruitMachineItem[] [] Matrix { get; set; }        
    }
}
