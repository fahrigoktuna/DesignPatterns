using DesignPatterns.GangOfFour.Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Strategy.Payments
{
    public class EFTPayment
    {
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public IFeeStrategy FeeStrategy => new EFT_FeeStrategy();
    }
}
