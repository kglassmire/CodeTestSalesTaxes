using System;
using System.Collections.Generic;
using System.Text;
using StoreDealerOn.Models;

namespace StoreDealerOn.Calcs
{
    abstract class TaxCalc
    {
        protected TaxCalc _successor;

        public void SetSuccessor(TaxCalc successor)
        {
            _successor = successor;
        }

        public abstract void Calculate(Item item);
    }
}
