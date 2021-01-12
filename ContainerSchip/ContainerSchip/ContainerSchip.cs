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

namespace ContainerSchip
{
    public partial class ContainerSchip : Form
    {
        Ship ship;
        public ContainerSchip()
        {
            InitializeComponent();
            ship = new Ship((int)LengthNUM.Value, (int)WidthNUM.Value);
            ContainerTypeCMB.Items.Add(ContainerTypes.Normal);
            ContainerTypeCMB.Items.Add(ContainerTypes.Valueble);
            ContainerTypeCMB.Items.Add(ContainerTypes.Cooled);
            ContainerTypeCMB.Items.Add(ContainerTypes.CooledValueble);
            ContainerTypeCMB.SelectedIndex = 0;
            UpdateCounters();
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            ship.ClearContainers();
            UpdateCounters();
        }
        private void ShipSizeChanged(object sender, EventArgs e)
        {
            ship.ChangeSize((int)LengthNUM.Value, (int)WidthNUM.Value);
            UpdateCounters();
        }

        private void AddContainerBTN_Click(object sender, EventArgs e)
        {
            List<Logic.Container> containers = new List<Logic.Container>();
            for(int i = 0; i<(int)AmountNUM.Value; i++)
            {
                containers.Add(new Logic.Container((ContainerTypes)ContainerTypeCMB.SelectedItem));
            }
            ship.AddContainers(containers);
            UpdateCounters();
        }

        private void UpdateCounters()
        {
            bool NoError = true;
            int amountNormal =0;
            int amountValueble = 0;
            int amountCooled = 0;
            int amountCooledValueble = 0;
            int weight = 0;

            foreach(Logic.Container container in ship.Containers)
            {
                weight += container.Weight;
                switch (container.Type)
                {
                    case ContainerTypes.Normal:
                        amountNormal++;
                        break;
                    case ContainerTypes.Valueble:
                        amountValueble++;
                        break;
                    case ContainerTypes.Cooled:
                        amountCooled++;
                        break;
                    case ContainerTypes.CooledValueble:
                        amountCooledValueble++;
                        break;
                }
            }
            if(amountCooledValueble > ship.Width)
            {
                CLDVALContainersTB.BackColor = ErrorColor;
                NoError = false;
            } else
            {
                CLDVALContainersTB.BackColor = White;
            }

            if(weight < ship.MinWeight)
            {
                NoError = false;
            }

            NRMContainersTB.Text = amountNormal.ToString();
            VALContainersTB.Text = amountValueble.ToString();
            CLDContainersTB.Text = amountCooled.ToString();
            CLDVALContainersTB.Text = amountCooledValueble.ToString();
            MaxWeigthTB.Text = ship.MaxWeight.ToString();
            MinimumWeightTB.Text = ship.MinWeight.ToString();
            CurrentWeightTB.Text = weight.ToString();
            if (NoError)
            {
                Visualize.Enabled = true;
            } else
            {
                Visualize.Enabled = false;
            }
        }

        private void Visualize_Click(object sender, EventArgs e)
        {
            ship.PlaceContainers();
            Process.Start(CreateVisualizationLink());
        }

        private string CreateVisualizationLink()
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


                for (int x = 0; x < ship.Rows[z].Columns.Count(); x++)
                {
                    if (x > 0)
                    {
                        stack += ",";
                        weight += ",";
                    }

                    for (int y = 0; y < ship.Rows[z].Columns[x].Containers.Count; y++)
                    {
                        Logic.Container container = ship.Rows[z].Columns[x].Containers[y];

                        stack += Convert.ToString((int)container.Type);
                        weight += Convert.ToString(container.Weight);
                        if (y < (ship.Rows[z].Columns[x].Containers.Count - 1))
                        {
                            weight += "-";
                        }

                    }
                }
            }
            return $"https://i872272core.venus.fhict.nl/ContainerVisualizer/index.html?length=" + ship.Length + "&width=" + ship.Width + "&stacks=" + stack + "&weights=" + weight;
        }

        private Color ErrorColor => Color.FromArgb(255, 128, 128);
        private Color White => Color.White;
    }
}
