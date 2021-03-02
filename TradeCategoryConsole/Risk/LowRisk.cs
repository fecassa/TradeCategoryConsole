using TradeCategoryConsole.Interfaces;

namespace TradeCategoryConsole.Risk
{
    public class LowRisk : IRisk
    {
        public string GetRisk()
        {
            return "LOWRISK";
        }
    }
}
