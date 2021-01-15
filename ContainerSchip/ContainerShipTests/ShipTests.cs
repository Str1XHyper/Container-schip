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
        public void Ship_Successfull()
        {
            //Act
            Ship ship = new Ship(4,3);

            //Assert
            Assert.AreEqual(4, ship.Length);
            Assert.AreEqual(3, ship.Width);
            Assert.AreEqual(3, ship.Rows.Length);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception),
            "Ship size can't be less then 1")]
        public void Ship_SizeToSmall()
        {
            //Act
            Ship ship = new Ship(0, 1);
        }

        [TestMethod()]
        public void AddContainers_Successfull()
        {
            //Arrange
            Ship ship = new Ship(3, 3);
            List<Container> containers = new List<Container>()
            {
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Cooled),
                new Container(ContainerTypes.Valueble),
                new Container(ContainerTypes.CooledValueble),
            };

            //Act
            ship.AddContainers(containers);

            //Assert
            Assert.AreEqual(6, ship.Containers.Count);
        }

        [TestMethod()]
        public void ClearContainers_Successfull()
        {
            //Arrange
            Ship ship = new Ship(3, 3);
            List<Container> containers = new List<Container>()
            {
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Cooled),
                new Container(ContainerTypes.Valueble),
                new Container(ContainerTypes.CooledValueble),
            };
            ship.AddContainers(containers);

            //Act
            ship.ClearContainers();

            //Assert
            Assert.AreEqual(0, ship.Containers.Count);
        }

        [TestMethod()]
        public void ChangeSize_Successfull()
        {
            //Arrange
            Ship ship = new Ship(3, 3);

            //Act
            ship.ChangeSize(5,2);

            //Assert
            Assert.AreEqual(5, ship.Length);
            Assert.AreEqual(2, ship.Width);

        }
        [TestMethod()]
        [ExpectedException(typeof(Exception),
            "Ship size can't be less then 1")]
        public void ChangeSize_SizeToSmall()
        {
            //Arrange
            Ship ship = new Ship(3, 3);

            //Act
            ship.ChangeSize(0, 2);
        }

        [TestMethod()]
        public void PlaceContainers_Successfull()
        {
            //Arrange
            Ship ship = new Ship(3, 3);
            List<Container> containers = new List<Container>()
            {
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Cooled),
                new Container(ContainerTypes.Valueble),
                new Container(ContainerTypes.CooledValueble),
            };
            ship.AddContainers(containers);

            //Act
            ship.PlaceContainers();
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Couldn't place all containers")]
        public void PlaceContainers_TooManyContainers()
        {
            Ship ship = new Ship(1, 1);
            List<Container> containers = new List<Container>()
            {
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Normal),
                new Container(ContainerTypes.Normal),
            };
            ship.AddContainers(containers);

            //Act
            ship.PlaceContainers();
        }


        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Couldn't place all containers")]
        public void PlaceContainers_TooManyCooledValuebleContainers()
        {
            Ship ship = new Ship(1, 1);
            List<Container> containers = new List<Container>()
            {
                new Container(ContainerTypes.CooledValueble),
                new Container(ContainerTypes.CooledValueble),
            };
            ship.AddContainers(containers);

            //Act
            ship.PlaceContainers();
        }
    }
}