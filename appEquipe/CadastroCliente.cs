using System;
using Microsoft.Maui.Controls;

namespace appEquipe
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void OnCadastroClicked(object sender, EventArgs e)
        {
            // Handle the Cadastro button click event
            DisplayAlert("Cadastro", "Cliente cadastrado com sucesso!", "OK");
        }

        private void OnPossuoCadastroTapped(object sender, EventArgs e)
        {
            // Handle the "Possuo cadastro" label tap event
            DisplayAlert("Login", "Navegando para a tela de login.", "OK");
            // Navigate to the login page (implement your navigation logic here)
            // For example: Navigation.PushAsync(new LoginPage());
        }
    }
}
