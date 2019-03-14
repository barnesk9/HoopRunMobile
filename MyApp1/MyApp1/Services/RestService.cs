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
    class RestService
    {
        HttpClient client;

        public List<Player> Players { get; private set; }

        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");
            client.BaseAddress =  new Uri("https://hooprunapitest.azurewebsites.net/api/players/");
        }

        public async Task<List<Player>> returnPlayerList()
        {
            List<Player> playerList = new List<Player>();
            var uri = new Uri("https://hooprunapitest.azurewebsites.net/api/players/");

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    playerList = JsonConvert.DeserializeObject<List<Player>>(content);
                    //playerList.Add(player);
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }

            return playerList;
        }

        public async Task<List<Gym>> returnGymList()
        {
            List<Gym> gymList = new List<Gym>();
            var uri = new Uri("https://hooprunapitest.azurewebsites.net/api/gyms/");

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    gymList = JsonConvert.DeserializeObject<List<Gym>>(content);
                    //playerList.Add(player);
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }

            return gymList;
        }

        public async Task<bool> AddPlayerAsync(Player player, bool isNewItem)
        {
            Player newPlayer = new Player();
            var uri = new Uri("https://hooprunapitest.azurewebsites.net/api/players");
            StringContent playerToPost = new StringContent( JsonConvert.SerializeObject(player));

            try
            {
                var response = await client.PostAsync(uri, playerToPost);
                if (response.IsSuccessStatusCode)
                { return true; }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }

            return false;
        }

        public Task DeleteTodoItemAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
