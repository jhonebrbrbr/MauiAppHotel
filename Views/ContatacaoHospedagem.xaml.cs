namespace MauiAppHotel.Views;

public partial class ContatacaoHospedagem : ContentPage
{
	public ContatacaoHospedagem()
	{
		InitializeComponent();
	}

    private void btn_sobre_Clicked(object sender, EventArgs e)
    {
        try
        {
            Application.Current.Windows[0].Page = new Sobre();
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", $"Ocorreu um erro ao navegar para a página Sobre: {ex.Message}", "OK");
        }
        

    }
}