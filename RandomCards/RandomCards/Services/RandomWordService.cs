using RandomWordCard.Interface;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace RandomWordCard.Services
{
    public class RandomWordService : IRandomWord
    {
        private static string URL = "https://random-word-api.herokuapp.com/word";
        private static HttpClient _httpClient { get; } = new HttpClient();

        public RandomWordService()
        {
        }

        public async Task<string> GetWord()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(URL);

                if (response.IsSuccessStatusCode)
                {
                    JsonArray wordArray = JsonSerializer.Deserialize<JsonArray>(await response.Content.ReadAsStringAsync());
                    var word = wordArray[0].ToString();
                    return word;
                }
                else
                {
                    throw new Exception(await response.Content.ReadAsStringAsync());
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
