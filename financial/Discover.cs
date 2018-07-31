namespace financial {

    public class Discover : CreditCard {
        private static decimal dInterestRate = .01m;

        public Discover() : base(interestRate : dInterestRate){}
    }
}