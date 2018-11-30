using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Strategy.Strategy
{
    public class Havale_FeeStrategy : IFeeStrategy
    {
        public decimal CalculateFee(decimal amount)
        {
            return Decimal.Multiply(amount, decimal.Parse("0,1"));
        }
    }
}
