namespace financial {

    public class Visa : CreditCard {
        private static decimal vInterestRate = 0.10m;
        public Visa() : base(interestRate: vInterestRate) {}
    }
}