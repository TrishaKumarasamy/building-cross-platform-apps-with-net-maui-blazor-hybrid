using HybridDashboard.Shared;

namespace HybridDashboard.Web
{
    public class WebCardPresenter : ICardPresenter
    {
        public DashboardSummary? CurrentSummary { get; private set; }

        public event Action<DashboardSummary>? SummaryUpdated;

        public void PublishSummary(DashboardSummary summary)
        {
            CurrentSummary = summary;
            SummaryUpdated?.Invoke(summary);
        }
    }
}