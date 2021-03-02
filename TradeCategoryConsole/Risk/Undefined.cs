using TradeCategoryConsole.Interfaces;

namespace TradeCategoryConsole.Risk
{
    public class Undefined : IRisk
    {
        public string GetRisk()
        {
            return "UNDEFINED";
        }
    }
}
