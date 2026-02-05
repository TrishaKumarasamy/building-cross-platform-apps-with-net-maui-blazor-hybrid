namespace HybridDashboard.Shared
{
    // Presenter contract used by shared razor pages to publish summary updates.
    public interface ICardPresenter
    {
        DashboardSummary? CurrentSummary { get; }

        event Action<DashboardSummary>? SummaryUpdated;
        void PublishSummary(DashboardSummary summary);
    }
}