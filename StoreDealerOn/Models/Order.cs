using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreDealerOn.Models
{
    public class Order
    {
        List<Item> Items { get; set; }

        public void Add(Item item)
        {
            if (Items == null)
                Items = new List<Item>();

            Items.Add(item);
        }

        public Receipt Checkout()
        {
            // group items by name
            var lineItems = Items.GroupBy(x => x.Name, (key, g) => new ReceiptLineItem(g.ToList()));

            Receipt receipt = new Receipt(lineItems.ToList());
            return receipt;
        }
    }
}
