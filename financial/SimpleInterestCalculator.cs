namespace financial {

    public class SimpleInterestCalculator : IInterestCalculator {

        public decimal GetMonthlyInterest(decimal iRate, decimal balance) {
            return iRate * balance;
        }
    }
}