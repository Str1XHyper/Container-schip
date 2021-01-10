using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public enum ContainerType
    {
        Normal = 0,
        Valueble = 1,
        Cooled = 2,
    }

    public class Container
    {
        public int Weight { get; private set; }
        public ContainerType ContainerType { get; private set; }

        public Container(ContainerType type, int Weight)
        {
            if(Weight < 4)
            {
                Weight = 4;
            } 
            else if (Weight > 120)
            {
                Weight = 120;
            }

            ContainerType = type;
            this.Weight = Weight;
        }
    }
}
