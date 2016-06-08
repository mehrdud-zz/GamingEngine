using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGE.GameEntities.Standard.Interfaces
{
    public interface IFruit
    {
        int FruitId { get; set; }
        string Name { get; set; }
        string ImageURL { get; set; }
    }
}
