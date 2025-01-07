using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LSPExample.Example;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }

    public virtual string GetMetaData() => Name;
    public virtual int GetTotal() => Quantity * Price;
}

public class TShirt : Product
{
    public override string GetMetaData() => $"{Name} TShirt";
    public override int GetTotal() => base.GetTotal() + 20;
}

public class Bag : Product
{
    public override string GetMetaData() => $"{Name} Bag";
    public override int GetTotal() => base.GetTotal() + 10;
}


public class Client
{
    public int Main()
    {
        Product bag1 = new Bag();
        Product bag2 = new Bag();
        Product tShirt1 = new TShirt();
        Product tShirt2 = new TShirt();

        // no error
        var list = new List<Product>() { bag1, bag2, tShirt1, tShirt2 };
        foreach (var item in list)
        {
            item.GetTotal();
            item.GetMetaData();
        } 
         
        return 0;
    }
}
