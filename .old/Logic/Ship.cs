using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Logic
{
    public class Ship
    {
        public int Length { get;  set; }
        public int Width { get;  set; }
        public int MaxWeight { get; private set; }
        public int MinWeight { get; private set; }
        private List<Container> containers; 
        public IReadOnlyCollection<Container> Containers { get { return containers; } }
        public Row[] Rows { get; private set; }
        public int WeightOfAllContainers { get { return CalculateWeight(); } }

        private float WeightDifference { get { return CalculateWeightDifference(); } }
        private int WeightLeft;
        private int WeightRight;
        private int TotalWeight;

        public Ship(int Length, int Width)
        {
            this.Length = Length;
            this.Width = Width;
            this.MaxWeight = (Length * Width) * 150;
            this.MinWeight = MaxWeight / 2;
            //rows = new Row[Width];
            containers = new List<Container>();
            Rows = InitializeRows().ToArray();
        }
        public void AddContainers(List<Container> containers)
        {
            this.containers.AddRange(containers);
        }

        public void ChangeShipSize(int Length, int Width)
        {
            this.Length = Length;
            this.Width = Width;
            this.MaxWeight = (Length * Width) * 150;
            this.MinWeight = MaxWeight / 2;
        }

        public void DistributeContainers()
        {
            Rows = InitializeRows().ToArray();

            var sortedContainers = containers.OrderByDescending(C => C.ContainerType).ThenByDescending(C => C.Weight).ToList();
            foreach (Container container in sortedContainers)
            {
                var LeftRightResult = AddContainerLeftOrRight(container);
                if (!LeftRightResult)
                {
                    if (Rows.Length % 2 != 0)
                    {
                        var CenterResult = AddContainerCenter(container);
                        if (!CenterResult)
                        {
                            throw new Exception("Couldn't place container!");
                        }
                    }
                }
            }
            if (TotalWeight < MinWeight)
            {
                throw new Exception("There are not enough containers on the ship!");
            }
            if (WeightDifference > 20)
            {
                throw new Exception("Weight difference is too big!");
            }
        }

        private bool AddContainerLeftOrRight(Container container)
        {
            for(int i =0; i<Rows.Length; i++)
            {
                if(WeightLeft <= WeightRight)
                {
                    if(Rows[i].Side == Row.RowSide.Left)
                    {
                        if (Rows[i].AddContainerToRow(container))
                        {
                            WeightLeft += container.Weight;
                            TotalWeight += container.Weight;
                            return true;
                        }
                    }
                } else
                {

                    if (Rows[i].Side == Row.RowSide.Right)
                    {
                        if (Rows[i].AddContainerToRow(container))
                        {
                            WeightRight += container.Weight;
                            TotalWeight += container.Weight;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool AddContainerCenter(Container container)
        {
            for (int i = 0; i < Rows.Length; i++)
            {
                if(Rows.Length % 2 != 0)
                {
                    if (Rows[i].AddContainerToRow(container))
                    {
                        TotalWeight += container.Weight;
                        return true;
                    }
                }
            }
            return false;
        }


        private float CalculateWeightDifference()
        {
            double percentageWeightLeft = ((double)WeightLeft / (double)TotalWeight) * 100;
            double percentageWeightRight = ((double)WeightRight / (double)TotalWeight) * 100;

            float WeightDifference = (float)percentageWeightLeft - (float)percentageWeightRight;
            if(WeightDifference < 0)
            {
                WeightDifference *= -1;
            }
            return WeightDifference;
        }
        
        private List<Row> InitializeRows()
        {
            List<Row> tempRows = new List<Row>();

            if(Width % 2 == 0)
            {
                for (int i = 0; i < Width; i++)
                {
                    int side;
                    if (i < Width / 2)
                    {
                        side = 1;
                    } else
                    {
                        side = 3;
                    }
                    tempRows.Add(new Row(Length, i, side));
                }
            } else
            {
                double middle = (Math.Floor((Width / 2f)));
                for (int i = 0; i < Width; i++)
                {
                    int side = 2;
                    if (i < middle)
                    {
                        side = 1;
                    }
                    else if (i > middle)
                    {
                        side = 3;
                    }

                    tempRows.Add(new Row(Length, i, side));
                }
            }
            return tempRows;
        }
        private int CalculateWeight()
        {
            int Weight = 0;
            foreach (Container container in containers)
            {
                Weight += container.Weight;
            }
            return Weight;
        }

    }
}
