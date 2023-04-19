namespace NetWorthCalculator.Pages
{
    public partial class LiabilitiesTable
    {
        // Liabilities
        private double? creditCardBalances { get; set; }
        private double? incomeTax { get; set; }
        private double? otherBills { get; set; }
        private double? homeMortgage { get; set; }
        private double? homeEquityLoan { get; set; }
        private double? rentalProperty { get; set; }
        private double? carLoan { get; set; }
        private double? studentLoan { get; set; }
        private double? lifeInsurance { get; set; }
        private double? otherLongTermDebt { get; set; }
        // Total Liabilities
        private double totalLiabilities { get; set; }
        public double GetTotalLiabilities()
        {
            return totalLiabilities;
        }

        private void UpdateTotalLiabilities()
        {
            totalLiabilities = (double)((creditCardBalances ?? 0) + (incomeTax ?? 0) + (otherBills ?? 0) + (homeMortgage ?? 0) + (homeEquityLoan ?? 0) + (rentalProperty ?? 0) + (carLoan ?? 0) + (studentLoan ?? 0) + (lifeInsurance ?? 0) + (otherLongTermDebt ?? 0));

        }
    }
}
