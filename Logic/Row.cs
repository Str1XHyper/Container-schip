using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Row
    {
        public enum RowSide
        {
            Left = 1,
            Center = 2,
            Right = 3,
        }


        public RowSide Side { get; private set; }
        private List<Stack> stacks;
        public int RowIndex { get; set; }
        public ReadOnlyCollection<Stack> Stacks { get { return stacks.AsReadOnly(); } }
        public Row(int rowSize, int position, int side)
        {
            stacks = new List<Stack>();
            for (int i = 0; i < rowSize; i++)
            {
                stacks.Add(new Stack(5, i, i == 0, i == rowSize - 1));
            }
            RowIndex = position;
            Side = (RowSide)side;
        }

        public bool AddContainerToRow(Container container)
        {
            for (int i = 0; i < stacks.Count; i++)
            {
                if (stacks[i].AddContainerToStack(container))
                {
                    if (container.ContainerType == ContainerType.Valueble)
                    {
                        if (!stacks[i].IsFront && !stacks[i].IsBack)
                        {
                            if (!stacks[i - 1].Reserved && i + 1 < stacks.Count)
                            {
                                stacks[i + 1].SetReserved();

                            }
                        }
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
