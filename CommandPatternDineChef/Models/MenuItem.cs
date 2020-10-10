using System;
using System.Collections.Generic;

namespace CommandPatternDineChef.Models
{
    public class Tag
    {
        public string TagName { get; set; }
    }

    public class MenuItem
    {
        public string Item { get; set; }
        public int Quantity { get; set; }
        public int TableNumber { get; set; }
        public List<Tag> Tags { get; set; }

        public void DisplayOrder()
        {
            Console.WriteLine("Table No: " + TableNumber);
            Console.WriteLine("Item: " + Item);
            Console.WriteLine("Quantity: " + Quantity);
            Console.Write("\tTags: ");
            foreach (var item in Tags)
            {
                Console.Write(item.TagName);
            }
        }
    }
}
