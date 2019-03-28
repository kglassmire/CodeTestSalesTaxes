using StoreDealerOn.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDealerOn.Calcs
{
    class RoundingTaxCalc : TaxCalc
    {
        public override void Calculate(Item item)
        {
            if (item.Tax > 0)
                item.Tax = Math.Ceiling((item.Tax) * 20) / 20;

            if(_successor != null)
            {
                _successor.Calculate(item);
            }
        }
    }
}
