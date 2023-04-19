namespace NetWorthCalculator.Pages
{
    public partial class AssetsTable
    {
         // Assets
    private double? checkingAccounts { get; set; }
    private double? savingsAccounts { get; set; }
    private double? moneyMarketAccounts { get; set; }
    private double? savingsBonds { get; set; }
    private double? cds { get; set; }
    private double? other { get; set; }
    public double  GetTotalCash()
    {
        return totalCash;
    }

    // total asserts
    public double totalCash { get; set; }
    private void UpdateTotalCash()
    {
            totalCash = (double)((checkingAccounts ?? 0) + (savingsAccounts ?? 0) + (moneyMarketAccounts ?? 0) + (savingsBonds ?? 0) + (cds ?? 0) + (other ?? 0));
        }
    }
}
