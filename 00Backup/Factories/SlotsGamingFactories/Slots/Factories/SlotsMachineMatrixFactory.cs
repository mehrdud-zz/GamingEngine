
using MGE.GameEntities.Standard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MGE.GamingEngine.SlotsGameEngine.Factories
{
    class SlotsMachineMatrixFactory 
    {
        public SlotsMachineMatrixFactory() 
        {
        }

        FruitMachineMatrix setupMatrix(int horizontalSize, int verticalSize)
        {
            var fruitMachineMatrix = new FruitMachineMatrix();
            return fruitMachineMatrix;            
        }
    }
}
