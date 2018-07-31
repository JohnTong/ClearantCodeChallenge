using Xunit;

namespace financial {

    public class InterestTest : IClassFixture<TestFixture> {

        TestFixture fixture = new TestFixture();

        [Fact]
        public void ItCalculatesPersonOnesInterest() {
            decimal total = 0m;
            decimal[] indInterest = new decimal[] {10m, 5m, 1m};
            foreach(Wallet w in fixture.p1.GetWallets()) {
                int i = 0;
                foreach(CreditCard c in w.GetCreditCards()) {
                    fixture.terms.SetiRate(c.InterestRate);
                    Assert.Equal(indInterest[i], fixture.terms.GetMonthlyInterest());
                    i++;
                    total += fixture.terms.GetMonthlyInterest();
                }
                Assert.Equal(16m, total);
            }
        }

        [Fact]
        public void ItCalculatesPersonTwosInterest() {
            decimal total = 0m;
            decimal[][] indInterest = new decimal[][] {
                new decimal[] {10m, 1m}, 
                new decimal[] {5m}
            };
            int j = 0;
            foreach(Wallet w in fixture.p2.GetWallets()) {
                int i = 0;
                foreach(CreditCard c in w.GetCreditCards()) {
                    fixture.terms.SetiRate(c.InterestRate);
                    Assert.Equal(indInterest[j][i], fixture.terms.GetMonthlyInterest());
                    i++;
                    total += fixture.terms.GetMonthlyInterest();
                }
                j++;
            }
            Assert.Equal(16m, total);
        }

        [Fact]
        public void ItCalculatesPersonThreeAndFoursInterest() {
            decimal total = 0m;

            foreach(Wallet w in fixture.p3.GetWallets()) {
                foreach(CreditCard c in w.GetCreditCards()) {
                    fixture.terms.SetiRate(c.InterestRate);
                    total += fixture.terms.GetMonthlyInterest();
                }
            }
            Assert.Equal(15m, total);

            total = 0m;

            foreach(Wallet w in fixture.p4.GetWallets()) {
                foreach(CreditCard c in w.GetCreditCards()) {
                    fixture.terms.SetiRate(c.InterestRate);
                    total += fixture.terms.GetMonthlyInterest();
                }
            }
            Assert.Equal(15m, total);
        }
    }
}