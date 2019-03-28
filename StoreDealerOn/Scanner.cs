using StoreDealerOn.Calcs;
using StoreDealerOn.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDealerOn
{
    public class Scanner
    {
        /// <summary>
        /// Chain the calculations necessary together. We can add more in the future if need be.
        /// </summary>
        /// <param name="item"></param>
        public static void Scan(Item item)
        {
            DutyTaxCalc dutyTaxCalc = new DutyTaxCalc();
            BasicTaxCalc basicTaxCalc = new BasicTaxCalc();
            RoundingTaxCalc roundingTaxCalc = new RoundingTaxCalc();

            dutyTaxCalc.SetSuccessor(basicTaxCalc);
            basicTaxCalc.SetSuccessor(roundingTaxCalc);
            dutyTaxCalc.Calculate(item);
        }
    }
}
