using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

          
        }

        /*protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }*/

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // var window = new Window(new AppShell()); // usar create window
            //var window = base.CreateWindow(activationState);

            var window = new Window(new NavigationPage(new Views.ContatacaoHospedagem()));

            window.Width = 480;
            window.Height = 700;
            window.X = 0;
            window.Y = 0;
            return window;
        }
    }
}