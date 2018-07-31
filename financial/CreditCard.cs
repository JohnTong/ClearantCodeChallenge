namespace financial {

    public class CreditCard {
        private decimal _interestRate;
        private int _balance;

        public CreditCard(decimal interestRate) {
            this._interestRate = interestRate;
        }

        public int Balance { get => _balance; set => _balance = value; }
        public decimal InterestRate { get => _interestRate; set => _interestRate = value; }
    }
}