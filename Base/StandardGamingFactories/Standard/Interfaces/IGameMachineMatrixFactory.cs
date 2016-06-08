using MGE.GameEntities.Standard.Entities;
using MGE.GameEntities.Standard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEG.GameFactories.Standard.Interfaces
{
    interface IGameMachineMatrixFactory
    {
        IFruitMachineMatrix setupMatrix(int horizontalSize, int verticalSize);
    }
}
