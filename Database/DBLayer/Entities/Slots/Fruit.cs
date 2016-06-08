using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.DBLayer.Entities.Slots
{
    public class Fruit : GameEntities.Standard.Interfaces.IFruit
    {
        public int FruitId { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
    }
}
