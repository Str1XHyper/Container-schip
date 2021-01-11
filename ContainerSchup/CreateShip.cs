using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerSchup
{
    public partial class CreateShip : Form
    {
        Ship ship;
        public CreateShip()
        {
            InitializeComponent();
            ship = new Ship((int)LengthNUM.Value, (int)WidthNUM.Value);
        }

        private void AddContainerBTN_Click(object sender, EventArgs e)
        {
            List<Logic.Container> containers = new List<Logic.Container>();
            if (ValuebleCB.Checked)
            {
                if (CooledCB.Checked)
                {
                    for(int i =0; i<AmountOfContainersNUM.Value; i++)
                    {
                        containers.Add(new Logic.Container(ContainerType.CooledValueble));
                    }
                }
                for (int i = 0; i < AmountOfContainersNUM.Value; i++)
                {
                    containers.Add(new Logic.Container(ContainerType.Valueble));
                }
            } else if (CooledCB.Checked)
            {
                for (int i = 0; i < AmountOfContainersNUM.Value; i++)
                {
                    containers.Add(new Logic.Container(ContainerType.Cooled));
                }
            } else
            {
                for (int i = 0; i < AmountOfContainersNUM.Value; i++)
                {
                    containers.Add(new Logic.Container(ContainerType.Normal));
                }
            }
            ship.AddContainers(containers);
            reloadListBox();
        }
        private void reloadListBox()
        {
            listBox1.Items.Clear();
            foreach(Logic.Container container in ship.Containers)
            {
                listBox1.Items.Add(container.ContainerType.ToString());
            }
        }


        private void LengthNUM_ValueChanged(object sender, EventArgs e)
        {
            ship.Length = (int)LengthNUM.Value;
        }

        private void WidthNUM_ValueChanged(object sender, EventArgs e)
        {
            ship.Width = (int)WidthNUM.Value;
        }

        private void VisualizeBTN_Click(object sender, EventArgs e)
        {
            ship.DistributeContainers();
            OpenVisualizer();
        }
        private void OpenVisualizer()
        {
            string stack = "";
            string weight = "";
            for (int z = 0; z < ship.Rows.Length; z++)
            {
                if (z > 0)
                {
                    stack += '/';
                    weight += '/';
                }


                for (int x = 0; x < ship.Rows[z].Stacks.Count; x++)
                {
                    if (x > 0)
                    {
                        stack += ",";
                        weight += ",";
                    }

                    for (int y = 0; y < ship.Rows[z].Stacks[x].Containers.Count; y++)
                    {
                        Logic.Container container = ship.Rows[z].Stacks[x].Containers[y];

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
    }
}
