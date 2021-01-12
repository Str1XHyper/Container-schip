using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public enum ContainerTypes
    {
        Normal = 1,
        Valueble = 2,
        Cooled = 3,
        CooledValueble = 4,
    }
    public class Container
    {
        public ContainerTypes Type { get; private set; }
        public int Weight { get; private set; } = 30;
        public Container(ContainerTypes type)
        {
            Type = type;
        }
    }
}
