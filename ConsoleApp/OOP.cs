using System;

public class Product
{
    private decimal _price;
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price
    {
        get
        {
            return _price;
        }
        set
        {
            if (value < 0) {
                _price = 0;
                Console.WriteLine("Value can't be negative!");
                return;
            }
            _price = value;
        }
    }
}
