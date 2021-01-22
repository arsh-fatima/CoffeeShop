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
    public partial class AddCoffee : Form
    {
        StringBuilder coffeeAdded = new StringBuilder("Coffee added: "); 
        StringBuilder maxcoffeeLimit = new StringBuilder("Maximum limit = 10"); 
        StringBuilder coffeeLimit = new StringBuilder("Cannot add more coffee!"); 
        public AddCoffee()
        {
            InitializeComponent();
        }

        private void mainLabel_Click(object sender, EventArgs e)
        {
        }
        Coffee Coff = new Coffee();
        private void ADD_Click(object sender, EventArgs e)
        {
                 if (Coff.CoffeeIn() == false)
                 {
                    Coff.AddCoffee();
                    textCoffee.Text = Convert.ToString(coffeeAdded.ToString()+ Coff.coffeeAdded); 
                    textCoffee.Text += System.Environment.NewLine + maxcoffeeLimit.ToString(); 
                 }
                else
                { MessageBox.Show(coffeeLimit.ToString()); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textCoffee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
