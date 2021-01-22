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
    public partial class buyCoffee : Form
    {
        string soldOut = string.Empty; 
        string coffeeBought = string.Empty; 
        string coffeeLeft = string.Empty; 

        public buyCoffee()
        {
            InitializeComponent();
        }
        Coffee Coff = new Coffee();
        private void BuyCoff_Click(object sender, EventArgs e)
        {
                if (Coff.CoffeeOut() == true)
                { MessageBox.Show(soldOut = "Sorry, coffee is sold out."); } 
                else
                {
                  Coff.BuyCoffee();
                  textBuyCoffee.Text = Convert.ToString(coffeeBought = "Coffee bought: " + Coff.coffeeBought); 
                  boughtCoffee.Text = Convert.ToString(coffeeLeft = "Coffee left: " + Coff.coffeeleft); 

                }
        }
        private void textBuyCoffee_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void boughtCoffee_TextChanged(object sender, EventArgs e)
        {

        }

        private void buyCoffee_Load(object sender, EventArgs e)
        {

        }
    }
}
