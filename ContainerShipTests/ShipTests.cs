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
    public class ShipTests
    {

        [TestMethod()]
        public void AddContainers_Successfull()
        {
            //Arrange
            Ship ship = new Ship(3, 3);
            List<Container> testContainers = new List<Container>()
            {
                new Container(ContainerType.Normal),
                new Container(ContainerType.Normal),
                new Container(ContainerType.Cooled),
                new Container(ContainerType.CooledValueble),
            };

            //Act
            ship.AddContainers(testContainers);
            //Assert
            Assert.AreEqual(4, ship.Containers.Count);
        }

        [TestMethod()]
        public void ChangeShipSize_Successfull()
        {
            //Arrange
            Ship ship = new Ship(3, 3);

            //Act
            ship.ChangeShipSize(4, 5);

            //Assert
            Assert.AreEqual(4, ship.Length);
            Assert.AreEqual(5, ship.Width);
        }

        [TestMethod()]
        public void DistributeContainers_Successfull()
        {
            //Arrange
            Ship ship = new Ship(3, 3);
            List<Container> testContainers = new List<Container>();
            for(int i = 0; i < 5; i++)
            {
                testContainers.Add(new Container(ContainerType.Cooled));
            }
            for (int i = 0; i < 5; i++)
            {
                testContainers.Add(new Container(ContainerType.Valueble));
            }
            for (int i = 0; i < 20; i++)
            {
                testContainers.Add(new Container(ContainerType.Normal));
            }

            //Act
            ship.AddContainers(testContainers);
            ship.DistributeContainers();
        }
        [TestMethod()]
        public void DistributeContainers_NotEnoughWeight()
        {
            //Arrange
            Ship ship = new Ship(3, 3);
            List<Container> testContainers = new List<Container>();
            for (int i = 0; i < 10; i++)
            {
                testContainers.Add(new Container(ContainerType.Normal));
            }

            //Act
            ship.AddContainers(testContainers);
            try
            {
                ship.DistributeContainers();
            } catch (Exception ex)
            {
                Assert.AreEqual("There are not enough containers on the ship!", ex.Message);
            }
        }
    }
}