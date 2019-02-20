using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MyApp1.Models;
using MyApp1.Services.Interfaces;

namespace MyApp1.Services
{
    class RestService:IRestService
    {
        HttpClient client;

        public List<Player> Players { get; private set; }

        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");  
        }

        public async Task<List<Player>> returnPlayerList()
        {
            var playerlist = RefreshDataAsync();

            return await playerlist;
        }

        public async Task<List<Player>> RefreshDataAsync()
        {
            List<Player> playerList = new List<Player>();
            var uri = new Uri("https://hooprunapitest.azurewebsites.net/api/players");

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    playerList = JsonConvert.DeserializeObject<List<Player>>(content);
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return playerList;
        }

        public Task GetPlayerAsync(Player player, bool isNewItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTodoItemAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
