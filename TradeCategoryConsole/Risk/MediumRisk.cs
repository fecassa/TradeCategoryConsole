using TradeCategoryConsole.Interfaces;

namespace TradeCategoryConsole.Risk
{
    public class MediumRisk: IRisk
    {
        public string GetRisk()
        {
            return "MEDIUMRISK";
        }
    }
}
