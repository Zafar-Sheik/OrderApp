using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMenuApp
{
    class MenuItem
    {
        public string itemName;
        public int itemQuantity;
        public decimal itemPrice;

        public decimal FinalPrice;

        public MenuItem(string pItemName, int pItemQuantity, decimal pItemPrice)
        {
            itemName = pItemName;
            itemQuantity = pItemQuantity;
            itemPrice = pItemPrice;
            
        }

        public void calcFinalPrice()
        {
            FinalPrice = itemPrice*itemQuantity;
        }


        
      
        
    }
}
