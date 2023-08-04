using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities {
    internal class SavingsAccount : Account {

        public int InterestRate { get; set; }

        public SavingsAccount() {

        }

        public SavingsAccount(int number, string holder, double balance, int interestRate) : base(number, holder, balance) {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate; 
        }
    }
}
