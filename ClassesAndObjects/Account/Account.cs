namespace Account
{
    class Account
    {
        private string name;
        private double money;

        public Account(string accountname, double funds)
        {
            name = accountname;
            money = funds;
        }

        public double Withdraw(double i)
        {
            money -= i;
            return i;
        }

        public double Balance(double i)
        {
            return money;
        }

        public double Deposit(double i)
        {
            return money += i;
        }

        public override string ToString()
        {
            return ( name+ ":$" +money);
        }
    }
}


