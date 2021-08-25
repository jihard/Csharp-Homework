using System;

namespace Firm
{
    public class Commission : Hourly
    {
        private double _grossSales;
        private double _comissionRate;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double comissionRate)
        : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _comissionRate = comissionRate;
        }

        public void AddSales(double grossSales)
        {
            _grossSales = grossSales;
        }
        public override double Pay()
        {
            var payment = base.Pay() + _grossSales * _comissionRate;
            _grossSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\n'Total sales: " + _grossSales;
            return result;
        }
    }
}

