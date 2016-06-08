using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GamingEngine.Standard.Interfaces
{
    public interface IFruit
    {
        Guid FruitId { get; set; }
        string Name { get; set; }
        string ImageURL { get; set; }
    }
}
