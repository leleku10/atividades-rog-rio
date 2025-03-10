using Microsoft.Maui.Controls;

namespace MeuProjetoMaui
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void OnNavigateButtonClick(object sender, EventArgs e)
		{
			// Código para navegar para a segunda página
			await Navigation.PushAsync(new SecondPage());
		}
	}
}
