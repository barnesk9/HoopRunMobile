using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;

using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MyApp1.Models;
using MyApp1.Services.Interfaces;
using RestSharp;
using RestSharp.Authenticators;


namespace MyApp1.Services
{
    class RestService:IRestService
    {
       // HttpClient client;

        public List<Player> Players { get; private set; }

        public RestService()
        {
            var authData = string.Format("{0}:{1}", "barnesk9", "password");
            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));


            //var response = client.Get(request);

            //client = new HttpClient();
            //client.MaxResponseContentBufferSize = 256000;
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);

            var playerlist = RefreshDataAsync();
        }

        public async Task<List<Player>> RefreshDataAsync()
        {

            var client = new RestClient("http://hooprunapitest.azurewebsites.net/api/")
            {
                //Authenticator = new HttpBasicAuthenticator("username", "password")
            };

            var request = new RestRequest("players", Method.GET);

            var response = client.Execute(request);
            
            List<Player> playerList = JsonConvert.DeserializeObject<List<Player>>(response.Content);

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
