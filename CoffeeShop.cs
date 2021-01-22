using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopSC {
    
        public partial class CoffeeShop : Form
        {
        public CoffeeShop()
        {
                InitializeComponent();
        } 
    
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            AddCoffee newForm = new AddCoffee();
            newForm.Show();
        }

        private void BUY_Click(object sender, EventArgs e)
        {
            buyCoffee newForm = new buyCoffee();
            newForm.Show();
        }

        private void mainLabel_Click(object sender, EventArgs e)
        {

        }

        private void CoffeeShop_Load(object sender, EventArgs e)
        {

        }

        private void viewCoffee_Click(object sender, EventArgs e)
        {
            viewCoffee newForm = new viewCoffee();
            newForm.Show();
        }
    }
}
