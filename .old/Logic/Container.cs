using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public enum ContainerType
    {
        Normal = 1,
        Valueble = 2,
        Cooled = 3,
        CooledValueble = 4,
    }

    public class Container
    {
        public int Weight { get; private set; }
        public ContainerType ContainerType { get; private set; }

        public Container(ContainerType type)
        {

            ContainerType = type;
            this.Weight = 30;
        }
    }
}
