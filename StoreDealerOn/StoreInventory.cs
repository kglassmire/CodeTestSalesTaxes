using StoreDealerOn.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDealerOn
{
    /// <summary>
    /// This is just a replacement for having some sort of database schema for inventory lookup.
    /// </summary>
    class StoreInventory
    {
        public static Item Book(Decimal price)
        {
            return new Item("Book", ItemLocality.Domestic, ItemType.Book, price);
        }

        public static Item MusicCD(Decimal price)
        {
            return new Item("Music CD", ItemLocality.Domestic, ItemType.Other, price);
        }

        public static Item ChocolateBar(Decimal price)
        {
            return new Item("Chocolate bar", ItemLocality.Domestic, ItemType.Food, price);
        }

        public static Item ImportedBoxChocolates(Decimal price)
        {
            return new Item("Imported box of chocolates", ItemLocality.Imported, ItemType.Food, price);
        }

        public static Item PacketHeadachePills(Decimal price)
        {
            return new Item("Packet of headache pills", ItemLocality.Domestic, ItemType.Medical, price);
        }

        public static Item BottleOfPerfume(Decimal price)
        {
            return new Item("Bottle of perfume", ItemLocality.Domestic, ItemType.Other, price);
        }

        public static Item ImportedBottleOfPerfume(Decimal price)
        {
            return new Item("Imported bottle of perfume", ItemLocality.Imported, ItemType.Other, price);
        }

    }
}
