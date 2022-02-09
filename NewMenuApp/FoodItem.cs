using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMenuApp
{
    class FoodItem : MenuItem
    {
        public FoodItem(string pItemName, int pItemQuantity, decimal pItemPrice) : base(pItemName, pItemQuantity, pItemPrice)
        {
        }
    }
}
