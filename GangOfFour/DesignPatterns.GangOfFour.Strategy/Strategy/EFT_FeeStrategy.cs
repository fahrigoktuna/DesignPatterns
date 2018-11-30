using System;

namespace DesignPatterns.GangOfFour.Strategy.Strategy
{
    public class EFT_FeeStrategy : IFeeStrategy
    {
        public decimal CalculateFee(decimal amount)
        {
            return Decimal.Multiply(amount, decimal.Parse("0,5"));
        }
    }
}
