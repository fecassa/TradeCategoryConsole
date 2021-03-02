using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCategoryConsole.Interfaces;

namespace TradeCategoryConsole.Trade
{
    public class Trade: ITrade
    {
        private static int auto_id = 1;

        public Trade()
        {
            Id = auto_id++;
        }

        public override string ToString()
        {            
            return string.Format( "Trade{0} = {{ Value = {1}, ClientSector = \"{2}\" }}", Id, Value, ClientSector);
        }
    }
}
