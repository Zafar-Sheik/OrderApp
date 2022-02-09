using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMenuApp
{
    class DrinkItem : MenuItem
    {
        public DrinkItem(string pItemName, int pItemQuantity, decimal pItemPrice) : base(pItemName, pItemQuantity, pItemPrice)
        {
        }

        public void setPrice(char itemSize)
        {
            if (itemSize == 'S')
            {
                itemPrice = itemPrice - 5;
            }

            if (itemSize == 'R')
            {
                itemPrice = itemPrice*1;
            }

            if (itemSize == 'L')
            {
                itemPrice = itemPrice + 5;
            }
        }

    }
}

