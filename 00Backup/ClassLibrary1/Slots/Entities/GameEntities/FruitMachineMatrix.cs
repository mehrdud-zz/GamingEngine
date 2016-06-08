using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGE.GamingEngine.Standard.Entities
{
    
    public class FruitMachineMatrix : Interfaces.IGameMachineMatrix
    {
        public int VerticalSize { get; set; }

        public int HorizontalSize { get; set; }

        public Fruit[] [] Matrix { get; set; }          
    }
}
