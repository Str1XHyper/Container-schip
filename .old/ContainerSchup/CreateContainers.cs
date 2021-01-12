using Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerSchup
{
    public partial class CreateContainers : Form
    {
        private Ship ship;
        public CreateContainers(Ship ship)
        {
            InitializeComponent();
            this.ship = ship;
        }

        private void LoadShipBTN_Click(object sender, EventArgs e)
        {
            List<Container> containers = new List<Container>();

            for(int i = 0; i< NormalNUM.Value; i++)
            {
                containers.Add(new Container(ContainerType.Normal));
            }

            for (int i = 0; i < CooledNUM.Value; i++)
            {
                containers.Add(new Container(ContainerType.Cooled));
            }

            for (int i = 0; i < ValuebleNUM.Value; i++)
            {
                containers.Add(new Container(ContainerType.Valueble));
            }
            ship.AddContainers(containers);

            Form ViewShip = new ViewShip(ship);
            ViewShip.Show();
            ViewShip.FormClosed += new FormClosedEventHandler(ViewShipClosed);
            this.Hide();
        }

        private void ViewShipClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
