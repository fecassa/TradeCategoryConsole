using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategoryConsole.Interfaces
{
    public class ITrade
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public string ClientSector { get; set; }
    }
}
