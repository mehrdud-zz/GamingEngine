using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;


namespace TestDBLayer
{
    [TestFixture]
    public class GenerateSchema_Fixture
    {
        [Test, Order(1)]
        public void Test_Can_generate_schema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(MGE.DBLayer.Entities.Slots.Fruit).Assembly);
            new SchemaExport(cfg).Execute(false, true, false);
        }

        [Test]
        public void Test_AddFruit()
        {
            var fruitController = new MGE.DBLayer.Controller.FruitController();

            var fruit = new MGE.DBLayer.Entities.Slots.Fruit(); 
            fruit.ImageURL = String.Empty;
            fruit.Name = "Fruit";
            fruitController.Add(fruit);
        }

    }
}