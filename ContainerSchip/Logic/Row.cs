using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public enum RowSide
    {
        Left = 1,
        Center =2,
        Right =3,
    }
    public class Row
    {
        public RowSide Side { get; private set; }
        public Column[] Columns { get; private set; }
        public int RowIndex { get; private set; }

        public Row(RowSide side, int index,int shipLength)
        {
            Side = side;
            RowIndex = index;
            Columns = new Column[shipLength];
            for(int i =0; i< shipLength; i++)
            {
                Columns[i] = new Column(i, i==0, i==shipLength-1);
            }
        }

        public bool AddContainer(Container container)
        {
            for(int i = 0; i< Columns.Length; i++)
            {
                bool result = Columns[i].TryToAddContainer(container);
                if (result)
                {
                    if(container.Type == ContainerTypes.Valueble || container.Type == ContainerTypes.CooledValueble)
                    {
                        if(i != 0 && i != Columns.Length-1)
                        {
                            Columns[i + 1].SetReserved();
                        }
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
