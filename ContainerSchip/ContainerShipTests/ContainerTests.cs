using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShipTests
{
    [TestClass()]
    public class ContainerTests
    {
        [TestMethod()]
        public void ContainerTest()
        {
            //Act
            Container container = new Container(ContainerTypes.Cooled);

            //Assert
            Assert.AreEqual(ContainerTypes.Cooled, container.Type);
        }
    }
}