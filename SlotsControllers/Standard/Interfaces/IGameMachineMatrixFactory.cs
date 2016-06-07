using MGE.GamingEngine.Standard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.StandardGamingFactories.Standard.Interfaces
{
    interface IGameMachineMatrixFactory
    {
        FruitMachineMatrix setupMatrix(int horizontalSize, int verticalSize);
    }
}
