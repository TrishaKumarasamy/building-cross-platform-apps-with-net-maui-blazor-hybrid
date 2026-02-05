using HybridDashboard.Shared;
using System.ComponentModel;

namespace HybridDashboard
{
    public class MauiCardPresenter : ICardPresenter, INotifyPropertyChanged
    {
        private DashboardSummary? _currentSummary;

        public DashboardSummary? CurrentSummary
        {
            get => _currentSummary;
            private set
            {
                if (_currentSummary != value)
                {
                    _currentSummary = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentSummary)));
                }
            }
        }

        public event Action<DashboardSummary>? SummaryUpdated;

        public void PublishSummary(DashboardSummary summary)
        {
            CurrentSummary = summary;
            SummaryUpdated?.Invoke(summary);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}