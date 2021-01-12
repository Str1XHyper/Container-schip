using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Column
    {
        private List<Container> containers = new List<Container>();
        public IReadOnlyList<Container> Containers => containers;
        private int MaxWeight = 150;
        public bool Reserved { get; private set; }
        public int ColumnIndex { get; private set; }
        public bool OnFrontOfShip { get; private set; }
        public bool OnBackOfShip { get; private set; }
        private int currentWeight;

        public Column(int index, bool onFront, bool onBack)
        {
            ColumnIndex = index;
            OnFrontOfShip = onFront;
            OnBackOfShip = onBack;
        }

        public bool TryToAddContainer(Container container)
        {
            if (Reserved)
            {
                return false;
            }
            if(container.Type == ContainerTypes.Cooled || container.Type == ContainerTypes.CooledValueble)
            {
                if(ColumnIndex != 0)
                {
                    return false;
                }
            }
            if((currentWeight + container.Weight) > MaxWeight)
            {
                return false;
            }

            if(container.Type == ContainerTypes.Valueble || container.Type == ContainerTypes.CooledValueble)
            {
                if(containers.Count == 0)
                {
                    AddContainer(container);
                    return true;
                } else if (containers[containers.Count-1].Type != ContainerTypes.Valueble && containers[containers.Count - 1].Type != ContainerTypes.CooledValueble)
                {
                    AddContainer(container);
                    return true;
                }
                return false;
            }
            containers.Insert(0, container);
            currentWeight += container.Weight;
            return true;
        }

        public void SetReserved()
        {
            Reserved = true;
        }

        private void AddContainer(Container container)
        {
            containers.Add(container);
            currentWeight += container.Weight;
        }
    }
}
