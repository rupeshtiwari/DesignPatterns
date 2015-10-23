using DesignPatterns.Creational.FactoryMethod.Motivation;
using DesignPatterns.Creational.FactoryMethod.Structure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class FactoryMethod
    {
        [TestMethod]
        public void I_Can_Create_MyProduct_By_ConcreteCreator()
        {
            var creator = new ConcreteCreator();
            var product = creator.CreateProduct();
            Assert.IsTrue(product.GetType() == typeof(MyProduct));
        }

        [TestMethod]
        public void I_Can_Create_MyDocument_By_MyApplication()
        {
            var creator = new MyApplication();
            var document = creator.CreateDocument();
            Assert.IsTrue(document.GetType() == typeof(MyDocument));
        }
    }
}

