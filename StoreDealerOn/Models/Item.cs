using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDealerOn.Models
{
    public class Item
    {
        public Item(String itemName, ItemLocality locality, ItemType itemType, Decimal price)
        {
            Name = itemName;
            Locality = locality;
            Type = itemType;
            Price = price;
        }

        public String Name { get; private set; }
        public ItemLocality Locality { get; private set; }
        public ItemType Type { get; private set; }
        public Decimal Price { get; private set; }
        public Decimal Tax { get; set; }
        public Decimal Total
        {
            get
            {
                return Tax + Price;
            }
        }
            
    }

    public enum ItemLocality
    {
        Domestic,
        Imported
    }

    public enum ItemType
    {
        Book,
        Food,
        Medical,
        Other
    }
}
