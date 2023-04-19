namespace NetWorthCalculator.Pages
{
    public partial class AssetsTable
    {
         // Assets
    private double checkingAccounts { get; set; }
    private double savingsAccounts { get; set; }
    private double moneyMarketAccounts { get; set; }
    private double savingsBonds { get; set; }
    private double cds { get; set; }
    private double other { get; set; }
    public double GetTotalCash()
    {
        return totalCash;
    }

    // total asserts
    public double totalCash { get; set; }
    private void UpdateTotalCash()
    {
        totalCash = checkingAccounts + savingsAccounts + moneyMarketAccounts + savingsBonds + cds + other;

    }
}
}
