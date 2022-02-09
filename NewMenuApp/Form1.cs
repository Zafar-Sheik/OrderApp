using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewMenuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string itemName = "";
        public int itemQuantity = 0;
        public decimal itemPrice = 0;

        public decimal FinalPrice = 0;
       

        public decimal[] arrPrice = new decimal[50];       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnFoodMenu_Click(object sender, EventArgs e)
        {
           
            pnlFoodMenu.Show();
            
            pnlDrinksMenu.Hide();


        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
           
            pnlDrinksMenu.Show();
            
            
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            pnlDrinksMenu.Hide();
        }


        public void calcTotalPayment()
        {

            decimal TotalPayment = 0;


            for (int  i = 0;  i < lstbxOrder.Items.Count;  i++)
            {
                TotalPayment = TotalPayment + arrPrice[i];
            }

            lblTotalPrice.Text = "TOTAL: R" + Convert.ToString(TotalPayment);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            calcTotalPayment();

           

        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            setQuantity();
            MenuItem menuItem = new MenuItem(itemName, itemQuantity, itemPrice);
            menuItem.calcFinalPrice();
            FinalPrice = menuItem.FinalPrice;

            lstbxOrder.Items.Add(itemName + " R" + Convert.ToString(FinalPrice));

            for (int  i = 0;  i < lstbxOrder.Items.Count;  i++)
            {
                arrPrice[i] = FinalPrice;
            }
        }

        public void setQuantity()
        {
            if (itemName == "Burger")
            {
                itemQuantity = Convert.ToInt32(scrlbarBurger.Value);
            }

            if(itemName == "Sandwich")
            {
                itemQuantity = Convert.ToInt32(scrlbarSandwich.Value);
            }

            if(itemName == "Fries")
            {
                itemQuantity = Convert.ToInt32(scrlbarFries.Value);
            }

            //DRINKS

            if (itemName == "Cooldrink")
            {
                itemQuantity = Convert.ToInt32(scrlbrCooldrink.Value);
            }

            if (itemName == "Lemonade")
            {
                itemQuantity = Convert.ToInt32(scrlbarLemonade.Value);
            }

            if (itemName == "Milkshake")
            {
                itemQuantity = Convert.ToInt32(scrlbarMilkshake.Value);
            }
        }

        private void picbxBurger_Click(object sender, EventArgs e)
        {
           

            scrlbarBurger.Enabled = true;
            scrlbarSandwich.Enabled = false;
            scrlbarFries.Enabled = false;

            scrlbrCooldrink.Enabled = false;
            scrlbarLemonade.Enabled = false;
            scrlbarMilkshake.Enabled = false;

            itemName = "Burger";
            itemPrice = 30;
            
        }

        private void picbxCooldrink_Click(object sender, EventArgs e)
        {
           

            scrlbarBurger.Enabled = false;
            scrlbarSandwich.Enabled = false;
            scrlbarFries.Enabled = false;

            scrlbrCooldrink.Enabled = true;
            scrlbarLemonade.Enabled = false;
            scrlbarMilkshake.Enabled = false;

            itemName = "Cooldrink";
            itemPrice = 12;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemName = "Lemonade";

            scrlbarBurger.Enabled = false;
            scrlbarSandwich.Enabled = false;
            scrlbarFries.Enabled = false;

            scrlbrCooldrink.Enabled = false;
            scrlbarLemonade.Enabled = true;
            scrlbarMilkshake.Enabled = false;

            itemName = "Lemonade";
            itemPrice = 20;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            
            scrlbarBurger.Enabled = false;
            scrlbarSandwich.Enabled = false;
            scrlbarFries.Enabled = false;

            scrlbrCooldrink.Enabled = false;
            scrlbarLemonade.Enabled = false;
            scrlbarMilkshake.Enabled = true;

            itemName = "Milkshake";
            itemPrice = 20;
            
        }

        private void picbxSandwich_Click(object sender, EventArgs e)
        {
            itemName = "Sandwich";

            scrlbarBurger.Enabled = false;
            scrlbarSandwich.Enabled = true;
            scrlbarFries.Enabled = false;

            scrlbrCooldrink.Enabled = false;
            scrlbarLemonade.Enabled = false;
            scrlbarMilkshake.Enabled = false;

            itemName = "Sandwich";
            itemPrice = 15;
            
        }

        private void picbxFries_Click(object sender, EventArgs e)
        {
            
            scrlbarBurger.Enabled = false;
            scrlbarSandwich.Enabled = false;
            scrlbarFries.Enabled = true;

            scrlbrCooldrink.Enabled = false;
            scrlbarLemonade.Enabled = false;
            scrlbarMilkshake.Enabled = false;

            itemName = "Fries";
            itemPrice = 10; 
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int i=0;

            i = lstbxOrder.SelectedIndex;

            lstbxOrder.Items.RemoveAt(i);
            arrPrice[i] = 0;

        }
    }
}
