namespace financial {

    public interface IInterestCalculatorInjector
    {
        void InjectCalculator(IInterestCalculator calculator);
    }
}