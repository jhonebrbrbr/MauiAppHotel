namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
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
            DisplayAlertAsync("Erro", $"Ocorreu um erro ao navegar para a página " +
                $"ContatacaoHospedagem: {ex.Message}", "OK");
        }

    }
}