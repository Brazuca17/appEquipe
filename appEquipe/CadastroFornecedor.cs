using Microsoft.Maui.Controls;
using System;

namespace appEquipe
{
    public partial class CadastroFornecedor : ContentPage
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Add your logic for the Add button click event here
            DisplayAlert("Alert", "Add button clicked", "OK");
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Add your logic for the Register button click event here
            DisplayAlert("Alert", "Register button clicked", "OK");
        }
    }
}
