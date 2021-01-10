using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerSchup
{
    public partial class CreateShip : Form
    {
        public CreateShip()
        {
            InitializeComponent();
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            Ship ship = new Ship((int)LengthNUM.Value, (int)WidthNUM.Value, (int)WeightNUM.Value);
            
            Form CreateContainer = new CreateContainers(ship);
            CreateContainer.Show();
            CreateContainer.FormClosed += new FormClosedEventHandler(CreateContainerClosed);
            this.Hide();
        }

        private void CreateContainerClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
