using TradeCategoryConsole.Interfaces;

namespace TradeCategoryConsole.Risk
{
    public static class Factory
    {

        public static IRisk GetClass(ITrade trade)
        {
            IRisk risk;
            if (trade.Value < 1000000 && trade.ClientSector.ToUpper().Equals("PUBLIC"))
                risk = new LowRisk();
            else if (trade.Value > 1000000 && trade.ClientSector.ToUpper().Equals("PUBLIC"))
                risk = new MediumRisk();
            else if (trade.Value > 1000000 && trade.ClientSector.ToUpper().Equals("PRIVATE"))
                risk = new HighRisk();
            else
                risk = new Undefined();

            return risk;
        }
    }
}
