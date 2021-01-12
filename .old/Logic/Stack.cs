using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Stack
    {
        private List<Container> containers = new List<Container>();
        public IReadOnlyList<Container> Containers { get { return containers; } }

        public int MaxWeight { get; private set; } = 150;
        public int CurrentWeight { get; set; }
        public int MaxHeight { get; set; }
        public bool IsFull { get; set; } = false;
        public bool Reserved { get; set; } = false;
        public int IndexInRow { get; private set; }
        public bool IsFront { get; private set; }
        public bool IsBack { get; private set; }

        public Stack(int maxHeight, int position, bool isFront, bool isBack)
        {
            MaxHeight = maxHeight;
            IndexInRow = position;
            IsFront = isFront;
            IsBack = isBack;
        }

        public bool AddContainerToStack(Container container)
        {
            if(containers.Count >= MaxHeight || Reserved || ((container.ContainerType == ContainerType.Cooled || container.ContainerType == ContainerType.CooledValueble) && IndexInRow != 0) || (CurrentWeight + container.Weight) > MaxWeight)
            {
                return false;
            }
            if(container.ContainerType == ContainerType.Valueble || container.ContainerType == ContainerType.CooledValueble)
            {
                if (containers.Count == 0)
                {
                    containers.Add(container);
                }
                else
                {
                    if(!(containers[containers.Count-1].ContainerType == ContainerType.Valueble) && !(containers[containers.Count - 1].ContainerType == ContainerType.CooledValueble))
                    {
                        containers.Add(container);
                    } else
                    {
                        return false;
                    }
                }
            } else
            {
                containers.Insert(0, container);
            }
            CurrentWeight += container.Weight;
            if (((CurrentWeight + container.Weight) >= MaxWeight) || containers.Count >= MaxHeight)
            {
                IsFull = true;
            }
            return true;
        }

        public void SetReserved()
        {
            Reserved = true;
        }
    }
}
