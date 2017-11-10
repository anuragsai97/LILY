using DryIoc;
using Prism.DryIoc;
using class_schedule.Views;
using Xamarin.Forms;

namespace class_schedule
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("Login");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<erpview>();
            Container.RegisterTypeForNavigation<Login>();
        }
    }
}
