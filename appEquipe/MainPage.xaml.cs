namespace appEquipe;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void clicked (object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new CadastroCliente();
  }
}

