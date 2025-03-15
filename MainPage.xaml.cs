public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private async void GoToCepPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CepPage");
    }
}
