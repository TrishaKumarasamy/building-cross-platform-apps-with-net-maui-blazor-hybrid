using HybridDashboard.Shared;

namespace HybridDashboard
{
    public partial class MainPage : ContentPage
    {
        public MainPage(ICardPresenter cardPresenter)
        {
            InitializeComponent();
            BindingContext = cardPresenter;
        }
    }
}