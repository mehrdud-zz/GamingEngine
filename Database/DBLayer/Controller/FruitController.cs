using NHibernate;
using MGE.DBLayer.NHibernate;
using System;

namespace MGE.DBLayer.Controller
{
    public interface IFruitController
    {
        void Add(GameEntities.Standard.Interfaces.IFruit fruit);
    }

    public class FruitController : IFruitController
    {       

        public void Add(GameEntities.Standard.Interfaces.IFruit fruit)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Save(fruit);
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
