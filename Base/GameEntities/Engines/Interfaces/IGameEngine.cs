using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.GameEntities.Engines.Interfaces
{
    public interface IGameEngine
    {
        Dictionary<string, string> GetServerDetails();
    }
}
