namespace financial {

    public interface IInterestCalculator
    {
        decimal GetMonthlyInterest(decimal iRate, decimal balance);
    }
}