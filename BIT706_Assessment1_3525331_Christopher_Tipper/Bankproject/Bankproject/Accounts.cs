using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankproject
{
    public abstract class Accounts
    {
        private string Account;
        protected static int accountID = 1;
        protected int iD;
        
        public Accounts() 
        {
           iD = accountID;
           accountID++;
        }

        public Accounts(string newAccount) : this()
        {
            Account = newAccount;
        }
        public virtual string Info()
        {
            return iD + " " + Account;
        }
        public override string ToString()
        {
            return Info();
        }
    }
    public class Everyday : Accounts 
    {
        public int fees;
        public Everyday(string newEveryday) : base(newEveryday) { }
        public Everyday(string newEveryday, int noFees) : this(newEveryday)
        {
            fees = noFees;
        }
        public override string Info()
        {
            return base.Info() + " " + fees + " No Fees";

        }

    }

    public class Investment : Accounts
    {
        public int feesAdded;
        public Investment(string newInvestment) : base(newInvestment) { }
        public Investment(string newInvestment, int feesIncluded) : this(newInvestment) 
        {
            feesAdded = feesIncluded;
        }
        public override string Info()
        {
            return base.Info() + " " + feesAdded + " Fees Included";

        }
    }

    public class Omni : Accounts
    {
        public int interestAdded;
        public Omni (string newInterest) : base(newInterest) { }
        public Omni (string newInterest, int feesAdded) : this(newInterest)
        {
            interestAdded = feesAdded;
        }
        public override string Info()
        {
            return base.Info() + " " + interestAdded + "Interest Included";

        }
    }
    


}
