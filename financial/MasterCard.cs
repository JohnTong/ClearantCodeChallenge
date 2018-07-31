namespace financial {

    public class MasterCard : CreditCard{
        private static decimal mInterestRate = .05m;
        public MasterCard() : base(interestRate : mInterestRate) {}
    }
}