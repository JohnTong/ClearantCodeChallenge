
using System.Collections.Generic;

namespace financial
{
    public class Person {
        private List<Wallet> _wallets = new List<Wallet>();

        public List<Wallet> GetWallets() {
            return _wallets;
        }
        public void AddWallet(Wallet anotherWallet) {
            _wallets.Add(anotherWallet);
        }
    }
}