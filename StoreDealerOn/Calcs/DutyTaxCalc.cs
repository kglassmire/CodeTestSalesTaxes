using StoreDealerOn.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDealerOn.Calcs
{
    class DutyTaxCalc : TaxCalc
    {
        public override void Calculate(Item item)
        {
            if (item.Locality == ItemLocality.Imported)
            {
                item.Tax += item.Price * .05M;
            }

            if (_successor != null)
            {
                _successor.Calculate(item);
            }
        }
    }
}
