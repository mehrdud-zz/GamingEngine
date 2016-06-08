using Ninject;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using Ninject.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.GameEngine
{

    


    /// <summary>
    /// In context of IoC, EngineDependencyInjector is the dependency injector class
    /// This class will decide which type of dependency needs to be injected into the client
    /// </summary>
    public class EngineDependencyInjector : NinjectModule
    {
        private string engineType;
        public EngineDependencyInjector(string engineType)
        {
            this.engineType = engineType;
        }

        public override void Load()
        {
            /// 
            /// I hate my implementation here
            /// This is not SOLID. Let's improve here
            ///             
 
            
       //     Bind<ICarFactory>()
       //.ToFactory(() => new UseFirstArgumentAsNameInstanceProvider());

       //     Bind<ICar>()
       //         .To<Mercedes>()
       //         .Named("Mercedes");



       //     switch (engineType)
       //     {
       //         case "p":
       //             Bind(typeof(MEG.GameFactories.GameEngine.Factories.IGameEngineFactory))
       //                 .To(typeof(MGE.GamingEngine.PokerEngine.Factories.Engine.PokerEngineFactory));
       //             break;
       //         case "s":
       //         default:
       //             Bind(typeof(MEG.GameFactories.GameEngine.Factories.IGameEngineFactory))
       //                 .To(typeof(MGE.GamingEngine.SlotsEngine.Engine.Factories.Engine.SlotsEngineFactory));
       //             break;
       //     }

        }
    }



}
