using System.Collections.Generic;

namespace financial
{
    public class Wallet
    {
        private List<CreditCard> _creditCards;
        public List<CreditCard> GetCreditCards() {
            return _creditCards;
        }

        public void SetCreditCards(List<CreditCard> creditCards) => _creditCards = creditCards;
    }
}