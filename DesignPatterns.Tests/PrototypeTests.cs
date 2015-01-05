using System;
using Xunit;

namespace DesignPatterns.Tests
{
    public class PrototypeTests
    {
        [Fact]
        public void I_Can_Create_Copy_Of_Sheep_Object()
        {
            var sila = new Sheep {Name = "Sila"};
            var silaClone =(Sheep) CloneFactory.GetClone(sila);
            Assert.Equal(sila.Name, silaClone.Name);
            Assert.NotEqual(sila, silaClone);
        }
    }

  
}
