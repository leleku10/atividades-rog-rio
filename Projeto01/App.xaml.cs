using Microsoft.Maui.Controls;

namespace MeuProjetoMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Definir a MainPage como uma NavigationPage para suporte a navegação
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
