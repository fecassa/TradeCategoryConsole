using TradeCategoryConsole.Interfaces;

namespace TradeCategoryConsole.Risk
{
    public class HighRisk: IRisk
    {
        public string GetRisk()
        {
            return "HIGHTRISK";
        }
    }
}
