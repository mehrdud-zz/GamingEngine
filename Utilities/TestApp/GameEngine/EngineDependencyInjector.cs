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
    public class EngineDependencyInjector 
    {
        private string engineType;
        public EngineDependencyInjector(string engineType)
        {
            this.engineType = engineType;
        }
  
    }



}
