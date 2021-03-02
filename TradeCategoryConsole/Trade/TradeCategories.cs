using System.Collections.Generic;
using TradeCategoryConsole.Risk;

namespace TradeCategoryConsole.Trade
{
    public class TradeCategories
    {        

        public List<string> GetCategories(List<Trade> trades)
        {
            List<string> Categories = new List<string>();

            foreach(Trade trade in trades)
            {
                Categories.Add(Factory.GetClass(trade).GetRisk());
            }

            return Categories;
        }
    }
}
