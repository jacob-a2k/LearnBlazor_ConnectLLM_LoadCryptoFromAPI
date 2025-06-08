using Zaliczenie.Components.Models;

namespace Zaliczenie.Components.Services;

public class CryptoService
{
    private readonly HttpClient _httpClient;
    private const string ApiKey = "d0930c8ac92ae2c5d070f74b6b81f83dc2c1313097ba4f46f79b91ad5fb52d88";
    private const int limit = 5;
    private const string Domain = "https://rest.coincap.io/v3/assets";

    public CryptoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<CoinCapAsset>> GetCoinsAsync()
    {
        var url = $"{Domain}?apiKey={ApiKey}&limit={limit}";
        var response = await _httpClient.GetFromJsonAsync<CoinCapResponse>(url);
        return response?.data ?? new List<CoinCapAsset>();
    }
}
