using System;

namespace LearnCSharp
{


    /*
    var stock = new Stock("Amazon");
            stock.Price = 100;

            stock.onPriceChanged += Stock_onPriceChanged;

            Console.WriteLine(stock.Price);
            stock.ChangeStockPriceBy(0.05m);
            stock.ChangeStockPriceBy(-0.05m);
            stock.ChangeStockPriceBy(0.00m);
            stock.ChangeStockPriceBy(0.05m);

            Console.WriteLine(stock.Price); 
    
     */


    public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);
    public class Stock
    {

        public event StockPriceChangeHandler onPriceChanged;

        public string Name { get; set; }
        public decimal Price { get; set; }
        public Stock(string name)
        {
            Name = name;
        }

        public void ChangeStockPriceBy(decimal percent)
        {
            decimal oldPrice = Price;
            Price += Math.Round(Price * percent, 2);

            if (onPriceChanged != null)
            {
                onPriceChanged(this, oldPrice);
            }

        }



        //for event in main
        private void Stock_onPriceChanged(Stock stock, decimal oldPrice)
        {
            string result = "";
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result = "up";
            }
            else if (oldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                result = "down";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine($"{stock.Name}: ${stock.Price} - {result}");
        }

    }



}
