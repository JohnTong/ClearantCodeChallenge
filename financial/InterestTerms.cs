namespace financial {

    public class InterestTerms : IInterestCalculatorInjector
    {
        IInterestCalculator _calc;
        private decimal _iRate;
        private decimal _balance;

        public void InjectCalculator(IInterestCalculator calc)
        {
            _calc = calc;
        }

        public decimal GetiRate()
        {
            return _iRate;
        }

        public void SetiRate(decimal value)
        {
            _iRate = value;
        }

        public decimal Getbalance()
        {
            return _balance;
        }

        public void Setbalance(decimal value)
        {
            _balance = value;
        }

        public decimal GetMonthlyInterest()
        {
            return _calc.GetMonthlyInterest(GetiRate(), Getbalance());
        }
    }
}