using System.Net.Http;

namespace HelloSalutApi
{
    public class HelloSalut
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://hellosalut.stefanbohacek.com";
        public HelloSalut()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetSalutByLanguage(string language)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/?lang={language}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetSalutByIp(string ip)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/?ip={ip}");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetSalutByCountryCode(string countryCode)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/?cc={countryCode}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
