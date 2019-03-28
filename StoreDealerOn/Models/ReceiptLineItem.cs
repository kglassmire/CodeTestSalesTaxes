using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreDealerOn.Models
{
    public class ReceiptLineItem
    {
        public ReceiptLineItem(List<Item> items)
        {
            Items = items;
            Calculate();
        }

        private List<Item> Items { get; set; }
        private Decimal Quantity => Items.Count;
        public Decimal Total => Items.Sum(x => x.Total);
        public Decimal Tax => Items.Sum(x => x.Tax);

        public String ReceiptLineItemText
        {
            get
            {
                if (Items.Count == 0)
                    return String.Empty;
                if (Items.Count == 1)
                    return String.Format($"{Items.First().Name}: {Total}");

                return String.Format($"{Items.First().Name}: {Total} ({Quantity} @ {Items.First().Total.ToString("0.00")})");
            }
        }

        private void Calculate()
        {
            foreach (var item in Items)
            {
                Scanner.Scan(item);
            }
        }
    }
}
