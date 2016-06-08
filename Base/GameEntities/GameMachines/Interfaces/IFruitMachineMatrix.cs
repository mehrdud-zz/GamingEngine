using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGE.GameEntities.Standard.Interfaces
{
    
    public interface IFruitMachineMatrix
    {
        int VerticalSize { get; set; }

        int HorizontalSize { get; set; }

        IFruit[] [] Matrix { get; set; }          
    }
}
