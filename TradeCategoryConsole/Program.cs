using System;
using System.Collections.Generic;
using System.Text;
using TradeCategoryConsole.Interfaces;
using TradeCategoryConsole.Trade;

namespace TradeCategoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TradeCategoryConsole.Trade.Trade> portifolio = new List<TradeCategoryConsole.Trade.Trade>();

            TradeCategoryConsole.Trade.Trade trade1 = new TradeCategoryConsole.Trade.Trade { Value = 2000000, ClientSector = "Private" };
            TradeCategoryConsole.Trade.Trade trade2 = new TradeCategoryConsole.Trade.Trade { Value = 400000, ClientSector = "Public" };
            TradeCategoryConsole.Trade.Trade trade3 = new TradeCategoryConsole.Trade.Trade { Value = 500000, ClientSector = "Public" };
            TradeCategoryConsole.Trade.Trade trade4 = new TradeCategoryConsole.Trade.Trade { Value = 3000000, ClientSector = "Public" };            

            portifolio.Add(trade1);
            portifolio.Add(trade2);
            portifolio.Add(trade3);
            portifolio.Add(trade4);            

            Console.Title = "Trade";
            Console.WriteLine("Input:");

            foreach(ITrade trade in portifolio)
            {
                Console.WriteLine(trade);
            }

            StringBuilder sbPortifolio = new StringBuilder();
            sbPortifolio.Append("portifolio = {");
            
            for (int increment = 0; increment < portifolio.Count; increment++)
            {
                sbPortifolio.Append(String.Format("Trade{0}", portifolio[increment].Id));

                if (!increment.Equals(portifolio.Count - 1))
                {
                    sbPortifolio.Append(", ");
                }                
            }
            sbPortifolio.Append("}");

            Console.WriteLine("\n" + sbPortifolio.ToString());

            TradeCategories tradeCategories = new TradeCategories();
            List<string> categories = tradeCategories.GetCategories(portifolio);

            StringBuilder sbCategories = new StringBuilder();
            sbCategories.Append("tradeCategories  = {");
            for (int increment = 0; increment < categories.Count; increment++)
            {
                sbCategories.Append(String.Format("{0}", categories[increment]));

                if (!increment.Equals(categories.Count - 1))
                {
                    sbCategories.Append(", ");
                }
            }
            sbCategories.Append("}");

            Console.WriteLine("\n" + sbCategories.ToString());

            Console.ReadKey();
        }
    }
}
