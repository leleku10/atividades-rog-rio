using Microsoft.Maui.Controls;

namespace MeuProjetoMaui
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        // Evento para voltar para a MainPage
        private async void OnBackButtonClick(object sender, EventArgs e)
        {
            // Voltar para a página anterior
            await Navigation.PopAsync();
        }
    }
}
