using System.Collections.Generic;
using System;
using Xunit;

namespace financial {
    public class TestFixture : IDisposable {
        public Person p1 = new Person();
        public Person p2 = new Person();
        public Person p3 = new Person();
        public Person p4 = new Person();
        public decimal balance = 100.00m;
        SimpleInterestCalculator siCalculator = new SimpleInterestCalculator();
        public InterestTerms terms = new InterestTerms();
        Wallet w1 = new Wallet();
        Wallet w2_1 = new Wallet();
        Wallet w2_2 = new Wallet();
        Wallet w3 = new Wallet();
        Wallet w4 = new Wallet();
        List<CreditCard> p1Wallet = new List<CreditCard> {new Visa(), new MasterCard(), new Discover()};
        List<CreditCard> p2Wallet1 = new List<CreditCard> {new Visa(), new Discover()};
        List<CreditCard> p2Wallet2 = new List<CreditCard> {new MasterCard()};
        List<CreditCard> p3Wallet = new List<CreditCard> {new MasterCard(), new Visa()};
        List<CreditCard> p4Wallet = new List<CreditCard> {new Visa(), new MasterCard()};

        public TestFixture() {
            w1.SetCreditCards(p1Wallet);
            p1.AddWallet(w1);
            w2_1.SetCreditCards(p2Wallet1);
            w2_2.SetCreditCards(p2Wallet2);
            p2.AddWallet(w2_1);
            p2.AddWallet(w2_2);
            w3.SetCreditCards(p3Wallet);
            p3.AddWallet(w3);
            w4.SetCreditCards(p4Wallet);
            p4.AddWallet(w4);
            terms.Setbalance(balance);
            terms.InjectCalculator(siCalculator);
        } 

        public void Dispose() {}
    }

}