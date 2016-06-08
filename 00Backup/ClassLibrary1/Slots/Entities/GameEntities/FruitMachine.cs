using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGE.GamingEngine.Standard.Entities
{
    public class FruitMachine : Interfaces.IFruitMachine
    {
        public Interfaces.IGameMachineMatrix FruitMachineMatrix { get; set; }
    }
}
