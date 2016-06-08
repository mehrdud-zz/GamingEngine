using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGE.GamingEngine.Standard.Entities
{
    public class Fruit : Interfaces.IFruit
    {
        public Guid FruitId { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
    }
}
