public class CepService
{
    public async Task<string> BuscarCepAsync(string cep)
    {
        using HttpClient client = new();
        var response = await client.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
        return response;
    }
}
