namespace Signalr.StockTicker
{
    public class Stock
    {
        public string Symbol { get; set; }

        public decimal DayOpen { get; private set; }

        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                if (price == value)
                    return;
                price = value;
                if (DayOpen == 0)
                    DayOpen = price;
            }
        }

        public decimal Change
        {
            get
            {
                return Price - DayOpen;
            }
        }

        public double PercentageChange
        {
            get
            {
                return (double)System.Math.Round(Change / price, 4);
            }
        }
    }
}