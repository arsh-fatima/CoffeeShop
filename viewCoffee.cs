using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopSC
{
    public partial class viewCoffee : Form
    {
        Coffee Coff = new Coffee();
        public viewCoffee()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            Coff.sortCoffee(Coffee.coffee, Coffee.coffee.Length);
            listBox1.Items.Clear();
            for (int i = 0; i < Coffee.coffee.Length; i++)
            {
                listBox1.Items.Add(Coffee.coffee[i]); 
            }
            sortLabel.Visible = true;
        }
    }
}
