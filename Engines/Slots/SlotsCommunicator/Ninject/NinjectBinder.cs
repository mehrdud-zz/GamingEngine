using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninject.Modules;
using Ninject;


namespace MGE.GamingEngine.SlotsEngine.Engine
{
    public class NinjectBinder : NinjectModule
    {
        public override void Load()
        {
            //Bind<MEG.GameFactories.GameEngine.Factories.IGameEngineFactory>().To<Factories.Engine.SlotsEngineFactory>();
        }
    }
}