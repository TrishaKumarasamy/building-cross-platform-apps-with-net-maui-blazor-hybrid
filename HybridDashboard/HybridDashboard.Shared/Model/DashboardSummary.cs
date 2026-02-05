namespace HybridDashboard.Shared
{
    //KPI Data Model
    public class DashboardSummary
    {
        public string? TotalRevenue { get; set; }
        public string? TotalOrders { get; set; }
        public string? ActiveCustomers { get; set; }
        public string? CustomerRetentionRate { get; set; }

        public string? RevenueImage { get; set; }
        public string? OrdersImage { get; set; }
        public string? CustomersImage { get; set; }
        public string? RetentionImage { get; set; }
    }
}