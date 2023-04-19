namespace NetWorthCalculator.Pages
{
    public partial class Index
    {
        private AssetsTable? assetsTable;
        private LiabilitiesTable? liabilitiesTable;

        private double? netWorth { get; set; }


        private void ShowNetWorth()
        {
            netWorth = assetsTable.GetTotalCash() - liabilitiesTable.GetTotalLiabilities();
        }
    }
}
