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
    public class ColumnTests
    {
        [TestMethod()]
        public void Column_Successfull()
        {
            //Act
            Column column = new Column(0, true, false);

            //Assert
            Assert.IsTrue(column.OnFrontOfShip);
            Assert.AreEqual(0, column.ColumnIndex);
        }

        [TestMethod()]
        public void TryToAddContainer_Successfull()
        {
            //Arrange
            Column column = new Column(0, true, false);
            Container container = new Container(ContainerTypes.Normal);

            //Act
            var result = column.TryToAddContainer(container);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void TryToAddContainer_InReservedRow()
        {
            //Arrange
            Column column = new Column(0, true, false);
            column.SetReserved();
            Container container = new Container(ContainerTypes.Normal);

            //Act
            var result = column.TryToAddContainer(container);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void TryToAddContainer_TwoValueblecontainers()
        {
            //Arrange
            Column column = new Column(0, true, false);
            Container container1 = new Container(ContainerTypes.Valueble);
            Container container2 = new Container(ContainerTypes.Valueble);

            //Act
            var result1 = column.TryToAddContainer(container1);
            var result2 = column.TryToAddContainer(container2);

            //Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
        [TestMethod()]
        public void TryToAddContainer_TooMuchWeight()
        {
            //Arrange
            Column column = new Column(0, true, false);
            Container container1 = new Container(ContainerTypes.Normal);
            Container container2 = new Container(ContainerTypes.Normal);
            Container container3 = new Container(ContainerTypes.Normal);
            Container container4 = new Container(ContainerTypes.Normal);
            Container container5 = new Container(ContainerTypes.Normal);
            Container container6 = new Container(ContainerTypes.Normal);

            //Act
            var result1 = column.TryToAddContainer(container1);
            var result2 = column.TryToAddContainer(container2);
            var result3 = column.TryToAddContainer(container3);
            var result4 = column.TryToAddContainer(container4);
            var result5 = column.TryToAddContainer(container5);
            var result6 = column.TryToAddContainer(container6);

            //Assert
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
            Assert.IsTrue(result4);
            Assert.IsTrue(result5);
            Assert.IsFalse(result6);
        }
        [TestMethod()]
        public void TryToAddContainer_CooledNotInFront()
        {
            //Arrange
            Column column = new Column(1, true, false);
            Container container= new Container(ContainerTypes.Cooled);

            //Act
            var result1 = column.TryToAddContainer(container);

            //Assert
            Assert.IsFalse(result1);
        }

        [TestMethod()]
        public void SetReservedTest()
        {
            //Arrange
            Column column = new Column(0, true, false);

            //Act
            column.SetReserved();

            //Assert
            Assert.IsTrue(column.Reserved);

        }
    }
}