using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppMapProject1.Views;
using AppMapProject1.ViewModels;
using Prism.Plugin.Popups;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppMapProject1
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<MasterDetail, MasterDetailViewModel>();
            containerRegistry.RegisterForNavigation<Tabbed, TabbedViewModel>();
            containerRegistry.RegisterForNavigation<TabChild, TabChildViewModel>();
            containerRegistry.RegisterForNavigation<TabChild1, TabChild1ViewModel>();
            containerRegistry.RegisterForNavigation<TabChild2, TabChild2ViewModel>();
            containerRegistry.RegisterPopupNavigationService();
            containerRegistry.RegisterForNavigation<PopUp, PopUpViewModel>();
        }
    }
}
