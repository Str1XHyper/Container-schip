using Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerSchup
{
    public partial class ViewShip : Form
    {
        List<Container> Containers = new List<Container>();
        Ship ship;

        Button[,] ContainerView = new Button[7,7];

        public ViewShip()
        {
            InitializeComponent();
        }

        private void InitializeVariables()
        {
            #region ButtonMatrix
            #region Row 1
            ContainerView[0, 0] = button1;
            ContainerView[0, 1] = button2;
            ContainerView[0, 2] = button3;
            ContainerView[0, 3] = button4;
            ContainerView[0, 4] = button5;
            ContainerView[0, 5] = button6;
            ContainerView[0, 6] = button7;
            #endregion

            #region Row 2
            ContainerView[1, 6] = button8;
            ContainerView[1, 5] = button9;
            ContainerView[1, 4] = button10;
            ContainerView[1, 3] = button11;
            ContainerView[1, 2] = button12;
            ContainerView[1, 1] = button13;
            ContainerView[1, 0] = button14;
            #endregion
            
            #region Row 3
            ContainerView[2, 6] = button15;
            ContainerView[2, 5] = button16;
            ContainerView[2, 4] = button17;
            ContainerView[2, 3] = button18;
            ContainerView[2, 2] = button19;
            ContainerView[2, 1] = button20;
            ContainerView[2, 0] = button21;
            #endregion

            #region Row 4
            ContainerView[3, 6] = button22;
            ContainerView[3, 5] = button23;
            ContainerView[3, 4] = button24;
            ContainerView[3, 3] = button25;
            ContainerView[3, 2] = button26;
            ContainerView[3, 1] = button27;
            ContainerView[3, 0] = button28;
            #endregion

            #region Row 5
            ContainerView[4, 6] = button29;
            ContainerView[4, 5] = button30;
            ContainerView[4, 4] = button31;
            ContainerView[4, 3] = button32;
            ContainerView[4, 2] = button33;
            ContainerView[4, 1] = button34;
            ContainerView[4, 0] = button35;
            #endregion

            #region Row 6
            ContainerView[5, 6] = button36;
            ContainerView[5, 5] = button37;
            ContainerView[5, 4] = button38;
            ContainerView[5, 3] = button39;
            ContainerView[5, 2] = button40;
            ContainerView[5, 1] = button41;
            ContainerView[5, 0] = button42;
            #endregion

            #region Row 7
            ContainerView[6, 6] = button43;
            ContainerView[6, 5] = button44;
            ContainerView[6, 4] = button45;
            ContainerView[6, 3] = button46;
            ContainerView[6, 2] = button47;
            ContainerView[6, 1] = button48;
            ContainerView[6, 0] = button49;
            #endregion
            #endregion
        }

        public ViewShip(Ship ship)
        {
            InitializeComponent();
            this.ship = ship;
            InitializeVariables();
            InitializeView(ship.Length, ship.Width);
            ship.DistributeContainers();
            OpenVisualizer();
        }

        private void OpenVisualizer()
        {
            string stack = "";
            string weight = "";
            for (int z = 0; z < ship.Rows.Length; z++)
            {
                //Length / Depth
                if (z > 0)
                {
                    stack += '/';
                    weight += '/';
                }


                for (int x = 0; x < ship.Rows[z].Stacks.Count; x++)
                {
                    //Width 
                    if (x > 0)
                    {
                        stack += ",";
                        weight += ",";
                    }

                    for (int y = 0; y < ship.Rows[z].Stacks[x].Containers.Count; y++)
                    {
                        Container container = ship.Rows[z].Stacks[x].Containers[y];

                        //Height
                        stack += Convert.ToString((int)container.ContainerType);
                        weight += Convert.ToString(container.Weight);
                        if (y < (ship.Rows[z].Stacks[x].Containers.Count - 1))
                        {
                            weight += "-";
                        }

                    }
                }
            }
            Process.Start($"https://i872272core.venus.fhict.nl/ContainerVisualizer/index.html?length=" + ship.Length + "&width=" + ship.Width + "&stacks=" + stack + "&weights=" + weight + "");
        }

        private void InitializeView(int length, int width)
        {
            foreach(Button button in ContainerView)
            {
                button.Enabled = false;
            }

            for(int x = 0; x < length; x++)
            {
                for(int y = 0; y < width; y++)
                {
                    ContainerView[x, y].Enabled = true;
                }
            }
        }
        
    }
}
