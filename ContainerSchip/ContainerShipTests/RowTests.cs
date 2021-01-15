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
    public class RowTests
    {
        [TestMethod()]
        public void Row_Successfull()
        {
            //Act
            Row row = new Row(RowSide.Center, 0, 3);

            //Assert
            Assert.AreEqual(3, row.Columns.Length);
            Assert.AreEqual(RowSide.Center, row.Side);
            Assert.AreEqual(0, row.RowIndex);
        }

        [TestMethod()]
        public void AddContainer_Successfull()
        {
            //Arrange
            Row row = new Row(RowSide.Center, 0, 1);
            Container container = new Container(ContainerTypes.Normal);

            //Act
            var result = row.AddContainer(container);

            //Arrange
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void AddContainer_SetNextColumnReserved()
        {
            //Arrange
            Row row = new Row(RowSide.Center, 0, 3);
            Container container1 = new Container(ContainerTypes.Valueble);
            Container container2 = new Container(ContainerTypes.Valueble);

            //Act
            var result1 = row.AddContainer(container1);
            var result2 = row.AddContainer(container2);

            //Arrange
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(row.Columns[2].Reserved);
        }
        [TestMethod()]
        public void AddContainer_TooManyContainers()
        {
            //Arrange
            Row row = new Row(RowSide.Center, 0, 1);
            Container container1 = new Container(ContainerTypes.Valueble);
            Container container2 = new Container(ContainerTypes.Valueble);

            //Act
            row.AddContainer(container1);
            var result = row.AddContainer(container2);

            //Arrange
            Assert.IsFalse(result);
        }
    }
}