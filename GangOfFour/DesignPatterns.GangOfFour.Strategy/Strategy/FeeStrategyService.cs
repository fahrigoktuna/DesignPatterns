using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Strategy.Strategy
{
    public class FeeStrategyService : IFeeStrategy
    {
        private readonly IFeeStrategy _feeStrategy;
        public FeeStrategyService(IFeeStrategy feeStrategy)
        {
            _feeStrategy = feeStrategy;
        }

        public decimal CalculateFee(decimal amount) => _feeStrategy.CalculateFee(amount);
    }
}
