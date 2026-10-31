namespace MauiAppHotel.Views;
public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void btn_voltar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Application.Current.Windows[0].Page = new ContatacaoHospedagem();
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", $"Ocorreu um erro ao navegar para a página Sobre: {ex.Message}", "OK");
        }


    }
}