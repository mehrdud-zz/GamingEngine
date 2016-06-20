using MGE.DBLayer.NHibernate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.DBLayer.Controller
{
    public interface IEngineController
    {
        void SaveGameEngine(GameEntities.Engines.Entities.GameEngine gameEngine);
    }
    public class EngineController : IEngineController
    {
        public void SaveGameEngine(GameEntities.Engines.Entities.GameEngine gameEngine)
        {
            

            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {                    
                    session.Save(gameEngine);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            } 
        }
    }
}
