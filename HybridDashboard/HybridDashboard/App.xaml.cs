namespace HybridDashboard
{
    public partial class App : Application
    {
        private readonly IServiceProvider _services;

        public App(IServiceProvider services)
        {
            InitializeComponent();
            _services = services;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var mainPage = _services.GetService(typeof(MainPage)) as MainPage ?? new MainPage(_services.GetService(typeof(HybridDashboard.Shared.ICardPresenter)) as HybridDashboard.Shared.ICardPresenter);
            return new Window(mainPage) { Title = "HybridDashboard" };
        }
    }
}
