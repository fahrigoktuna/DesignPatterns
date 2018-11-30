using DesignPatterns.GangOfFour.Strategy.Payments;
using DesignPatterns.GangOfFour.Strategy.Strategy;
using System;

namespace DesignPatterns.GangOfFour.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            EFTPayment eftPAyment = new EFTPayment() { Amount = 10 };

            eftPAyment.Fee = new FeeStrategyService(eftPAyment.FeeStrategy).CalculateFee(eftPAyment.Amount);

            HavalePayment havalePayment = new HavalePayment() { Amount = 10 };

            havalePayment.Fee = new FeeStrategyService(havalePayment.FeeStrategy).CalculateFee(havalePayment.Amount);

            Console.Read();
        }
    }
}
