namespace MauiAppHotel.Views;

public partial class ContatacaoHospedagem : ContentPage
{
    App PropriedadesApp;
	public ContatacaoHospedagem()
	{
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.Lista_Quartos;

        dtpck_chekin.MinimumDate = DateTime.Now;
        dtpck_chekin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1,DateTime.Now.Day);

        /*O ?? diz: “se .Date for null, usa DateTime.Now.AddDays(...) como fallback” — 
         * no construtor ele nunca vai ser null na prática, mas o compilador exige o tratamento.*/
        dtpck_chekout.MinimumDate = dtpck_chekin.Date?.AddDays(1) ?? DateTime.Now.AddDays(1);
        dtpck_chekout.MaximumDate = dtpck_chekin.Date?.AddMonths(6) ?? DateTime.Now.AddMonths(6);
    }

    private void btn_sobre_Clicked(object sender, EventArgs e)
    {
        try
        {
            Application.Current.Windows[0].Page = new Sobre();
        }
        catch (Exception ex)
        {
            DisplayAlertAsync("Erro", $"Ocorreu um erro ao navegar para a página Sobre: {ex.Message}", "OK");
        }
        

    }

    private void btn_avancar_clicked(object sender, EventArgs e)
    {
        try
        {
            Application.Current.Windows[0].Page = new HospedagemContratada();
        }
        catch (Exception ex)
        {
            DisplayAlertAsync("Erro", $"Ocorreu um erro ao navegar para a página HospedagemContratada: {ex.Message}", "OK");
        }


    }

    private void dtpck_chekin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;


        DateTime data_selecionada_checkin = elemento.Date.Value;

        dtpck_chekout.MinimumDate = data_selecionada_checkin.AddDays(1);

        dtpck_chekout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }




}