using DesignPatterns.GangOfFour.Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Strategy.Payments
{
    public class HavalePayment
    {
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public IFeeStrategy FeeStrategy => new Havale_FeeStrategy();
    }
}
