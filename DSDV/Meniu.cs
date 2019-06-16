using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDV
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void buttonRouterToDelete_Click(object sender, EventArgs e)
        {
            Graph.RemoveRouter(textBoxRouterToDelete.Text);
            textBoxRouterToDelete.Text = "";
        }

        private void buttonAddRouter_Click(object sender, EventArgs e)
        {
            Graph.AddRouter(new Router(textBoxAddRouter.Text));
            textBoxAddRouter.Text = "";
        }

        private void buttonAddLink_Click(object sender, EventArgs e)
        {
            Graph.AddLink(textBoxAddLinkA.Text, textBoxAddLinkB.Text, Convert.ToInt32(numericUpDownWeight.Text));
            textBoxAddLinkA.Text = "";
            textBoxAddLinkB.Text = "";
            numericUpDownWeight.Text = "0";
        }
    }
}
