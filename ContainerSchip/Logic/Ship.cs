using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class Ship
    {
        public int Length { get; private set; }
        public int Width { get; private set; }
        public int MaxWeight { get { return (Length * Width) * 150; }}
        public int MinWeight { get { return MaxWeight / 2; } }
        public Row[] Rows { get; private set; }
        private int WeightLeft;
        private int WeightRight;
        private int CurrentWeight;
        public decimal WeightDifference { get { return CalculateWeightDifference(); } }


        private List<Container> containersToPlace = new List<Container>();
        public IReadOnlyList<Container> Containers => containersToPlace;
        
        public Ship(int length, int width)
        {
            Length = length;
            Width = width;
            Rows = new Row[width];
        }

        public void AddContainers(List<Container> containers)
        {
            containersToPlace.AddRange(containers);
        }

        public void ClearContainers()
        {
            containersToPlace = new List<Container>();
        }

        public void ChangeSize(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public void PlaceContainers()
        {
            Rows = InitializeRows();
            SortContainers();
            foreach(Container container in containersToPlace)
            {
                foreach(Row row in Rows)
                {
                    if(row.Side == CheckWhereToPlace())
                    {
                        bool result = row.AddContainer(container);
                        if (!result && Width % 2 != 0)
                        {
                            Row centerRow = Array.Find(Rows, CenterRow);
                            bool centerResult = centerRow.AddContainer(container);
                            if (!centerResult)
                            {
                                throw new Exception("Couldn't place all containers");
                            }
                            else
                            {
                                CurrentWeight += container.Weight;
                            }
                        } else if(!result && Width % 2 == 0)
                        {
                            throw new Exception("Couldn't place all containers");
                        }
                        else if(result)
                        {
                            CurrentWeight += container.Weight;
                            switch (row.Side)
                            {
                                case RowSide.Left:
                                    WeightLeft += container.Weight;
                                    break;
                                case RowSide.Right:
                                    WeightRight += container.Weight;
                                    break;
                            }
                            break;
                        }
                    }
                }
            }
        }
        private static bool CenterRow(Row r)
        {
            return r.Side == RowSide.Center;
        }
        private void SortContainers()
        {
            containersToPlace = containersToPlace.OrderByDescending(c => c.Type).ToList();
        }

        private RowSide CheckWhereToPlace()
        {
            if(WeightLeft <= WeightRight)
            {
                return RowSide.Left;
            }
            else
            {
                return RowSide.Right;
            }
        }
        private decimal CalculateWeightDifference()
        {
            decimal percentageLeft = ((decimal)WeightLeft / (decimal)CurrentWeight);
            decimal percentageRight = ((decimal)WeightRight / (decimal)CurrentWeight);

            decimal difference = percentageLeft - percentageRight;
            if(difference < 0)
            {
                difference *= -1;
            }
            return difference;
        }
        private Row[] InitializeRows()
        {
            List<Row> tempRows = new List<Row>();

            if (Width % 2 == 0)
            {
                for (int i = 0; i < Width; i++)
                {
                    int side;
                    if (i < Width / 2)
                    {
                        side = 1;
                    }
                    else
                    {
                        side = 3;
                    }
                    tempRows.Add(new Row((RowSide)side, i, Length));
                }
            }
            else
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

                    tempRows.Add(new Row((RowSide)side, i, Length));
                }
            }
            return tempRows.ToArray();
        }
    }
}
