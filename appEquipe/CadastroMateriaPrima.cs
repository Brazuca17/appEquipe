using Microsoft.Maui.Controls;
using System;

namespace appEquipe
{
    public partial class CadastroMateriaPrima : ContentPage
    {
        public CadastroMateriaPrima()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Add your logic for the Save button click event here
            DisplayAlert("Alert", "Save button clicked", "OK");
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            // Add your logic for the Cancel button click event here
            DisplayAlert("Alert", "Cancel button clicked", "OK");
        }

         private void VoltarMenu (object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new MainPage();
  }
    }
}
