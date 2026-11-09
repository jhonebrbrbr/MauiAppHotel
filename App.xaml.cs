using Microsoft.Extensions.DependencyInjection;
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> Lista_Quartos = new List<Quarto>

        { 
            new Quarto(){ Descricao = "Quarto Simples", Vlr_Diaria_Adulto = 100.00, Vlr_Diaria_Crianca = 50.00 },
            new Quarto() { Descricao = "Super Luxo", Vlr_Diaria_Adulto = 200.00, Vlr_Diaria_Crianca = 100.00 },
            new Quarto() { Descricao = "Quarto Hiper Economico", Vlr_Diaria_Adulto = 80.00, 
                Vlr_Diaria_Crianca = 35.00 },
            new Quarto() { Descricao = "Super Hiper Presidencial", 
                Vlr_Diaria_Adulto = 400.00, Vlr_Diaria_Crianca = 250.00 }

        }
        ;

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