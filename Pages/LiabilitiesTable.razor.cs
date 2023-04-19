namespace NetWorthCalculator.Pages
{
    public partial class LiabilitiesTable
    {
        // Liabilities
        private double creditCardBalances { get; set; }
        private double incomeTax { get; set; }
        private double otherBills { get; set; }
        private double homeMortgage { get; set; }
        private double homeEquityLoan { get; set; }
        private double rentalProperty { get; set; }
        private double carLoan { get; set; }
        private double studentLoan { get; set; }
        private double lifeInsurance { get; set; }
        private double otherLongTermDebt { get; set; }
        // Total Liabilities
        private double totalLiabilities { get; set; }
        public double GetTotalLiabilities()
        {
            return totalLiabilities;
        }

        private void UpdateTotalLiabilities()
        {
            totalLiabilities = creditCardBalances + incomeTax + otherBills + homeMortgage + homeEquityLoan + rentalProperty + carLoan + studentLoan + lifeInsurance + otherLongTermDebt;
        }
    }
}
