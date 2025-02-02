using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents;

public delegate void StockPriceChangedHandler(string stockName, decimal newPrice);
public class Stock
{
    // Both Works event and Delegate
    //public StockPriceChangedHandler PriceChanged; // Delegate as a public field
    public event StockPriceChangedHandler PriceChanged; 

    private string _name;
    private decimal _price;

    public Stock(string name, decimal initialPrice)
    {
        _name = name;
        _price = initialPrice;
    }

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (_price != value) 
            {
                _price = value;
                OnPriceChanged();
            }
        }
    }

    protected virtual void OnPriceChanged()
    {
        PriceChanged?.Invoke(_name, _price); 
    }
}