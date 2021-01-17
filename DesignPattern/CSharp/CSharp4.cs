using System;
using System.Collections.Generic;

#region IComparable 
/*
IComparable interface 
    -  only ine method [int CompareTo(object obj)] (obj is next element
       it compares the current object with the object next inline;
       e.g., to sort the list of integers sort method does bubble sort on elements.

    returns : 
        current > next  :  1 [swap]
        if same         :  0 [retain]
        else            : -1 [no swap]


IComparer
    used when sorting on a class on which you don't have control. (dll)


*/
namespace DesignPattern.CSharp
{

    public class SmartPhone : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString() => "Name: " + Name + "||" + " Price: " + Price;
        static List<SmartPhone> GetSmartPhone()
        {
            return new List<SmartPhone>()
            {
                new SmartPhone()
                {
                    Name = "One Plus 8",
                    Price = 55000
                },
                new SmartPhone()
                {
                    Name = "IPhone 11",
                    Price = 75000
                },
                new SmartPhone()
                {
                    Name = "Samsung Note 10",
                    Price = 110000
                },
                new SmartPhone()
                {
                    Name = "Samsung S20 Ultra",
                    Price = 130000
                }
            };
        }

        public int CompareTo(object obj)
        {
            //obj is : next object which is coming as a parameter
            if (obj == null) return 1;
            SmartPhone nextSmartPhone = obj as SmartPhone;
            return this.Price.CompareTo(nextSmartPhone.Price);
        }

        public static void Main1(string[] args)
        {
            var smartPhones = GetSmartPhone();
            smartPhones.Sort(); //////////
            foreach (var item in smartPhones)
                System.Console.WriteLine(item.ToString());
        }
    }
}

#endregion

#region IComparer
public class Display
{
    public int Price { get; set; }
    public string Resolution { get; set; }
    public string Size { get; set; }
}

public class SortDisplay : IComparer<Display>
{
    public int Compare(Display x, Display y)
    {
        Display firstDisplay = x as Display;
        Display secondDisplay = y as Display;
        return firstDisplay.Price.CompareTo(secondDisplay.Price);
    }

}

public class Use
{
    public static List<Display> GetDisplays()
    {
        return new List<Display>()
          {
              new Display()
              {
                  Price = 224,
                  Resolution = "1080 * 1920",
                  Size = "6.1"
              },
              new Display()
              {
                  Price = 300,
                  Resolution = "1440 * 2180",
                  Size = "7.1"
              },
              new Display()
              {
                  Price = 115,
                  Resolution = "564 * 900",
                  Size = "4.2"
              },
          };
    }
    public static void Main1(string[] args)
    {
        var lstDisplays = GetDisplays();
        SortDisplay sorted = new SortDisplay();
        lstDisplays.Sort(sorted);
        foreach (var item in lstDisplays)
            System.Console.WriteLine("RRPrice: " + item.Price + " Resolution: " + item.Resolution + " Size: " + item.Size);
    }
}
#endregion