namespace DesignPatterns.GangOfFour.Strategy.Strategy
{
    public interface IFeeStrategy
    {
        decimal CalculateFee(decimal amount);
    }
}
