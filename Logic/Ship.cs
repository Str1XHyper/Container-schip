using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Ship
    {
        public int Length { get; private set; }
        public int Width { get; private set; }
        /// <summary>
        /// Max weight of the ship in tons
        /// </summary>
        public int MaxWeight { get; private set; }

        List<Container[,]> containers = new List<Container[,]>();


        public Ship(int Length, int Width, int MaxWeight)
        {
            this.Length = Length;
            this.Width = Width;
            this.MaxWeight = MaxWeight;
        }

        private void PlaceContainer()
        {
        }
    }
}
