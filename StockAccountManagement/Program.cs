using System;

namespace StockAccountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stocks stock = new Stocks();
            stock.Stock_Management();
            stock.CalculateEachStockValue();
            stock.CalculateTotalStockValue();
            Console.Read();
        }
    }
}
