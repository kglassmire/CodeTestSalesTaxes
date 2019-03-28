using StoreDealerOn.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDealerOn.Calcs
{
    class BasicTaxCalc : TaxCalc
    {
        public override void Calculate(Item item)
        {
            if (item.Type == ItemType.Other)
            {
                item.Tax += item.Price * .10M;
            }
            
            if (_successor != null)
            {
                _successor.Calculate(item);
            }
        }
    }
}
