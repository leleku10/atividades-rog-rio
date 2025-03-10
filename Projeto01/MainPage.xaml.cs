using Microsoft.Maui.Controls;

namespace MeuProjetoMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Exibe um alerta simples
        private async void OnAlertButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Este é um alerta simples.", "OK");
        }

        // Exibe um alerta de confirmação
        private async void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            bool resposta = await DisplayAlert("Confirmar", "Você tem certeza que deseja continuar?", "Sim", "Não");

            if (resposta)
            {
                welcomeLabel.Text = "Você clicou em Sim!";
            }
            else
            {
                welcomeLabel.Text = "Você clicou em Não!";
            }
        }

        // Exibe um action sheet para o usuário escolher uma opção
        private async void OnActionSheetButtonClicked(object sender, EventArgs e)
        {
            string escolha = await DisplayActionSheet("Escolha uma opção", "Cancelar", null, "Opção 1", "Opção 2", "Opção 3");

            welcomeLabel.Text = $"Você escolheu: {escolha}";
        }
    }
}
