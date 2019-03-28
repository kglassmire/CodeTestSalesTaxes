using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreDealerOn.Models
{
    public class Receipt
    {
        public Receipt(List<ReceiptLineItem> lineItems)
        {
            LineItems = lineItems;
        }

        public List<ReceiptLineItem> LineItems { get; private set; }

        private void PrintLineItems()
        {
            foreach (var item in LineItems)
            {
                Console.WriteLine(item.ReceiptLineItemText);
            }
        }

        private void PrintSalesTaxes()
        {
            Console.WriteLine($"Sales Taxes: {LineItems.Sum(x => x.Tax).ToString("0.00")}");
        }

        private void PrintTotal()
        {
            Console.WriteLine($"Total: {LineItems.Sum(x => x.Total).ToString("0.00")}");
        }

        public void PrintReceipt()
        {
            PrintLineItems();
            PrintSalesTaxes();
            PrintTotal();
        }
    }
}
