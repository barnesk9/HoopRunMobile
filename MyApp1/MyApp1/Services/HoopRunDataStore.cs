using MyApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1.Services
{
    class HoopRunDataStore
   {
        List<Player> playerList;

        public HoopRunDataStore()
        {
            playerList = new List<Player>
            {
                new Player { Firstname = "Test", Lastname = "Person0"},
                new Player { Firstname = "Test", Lastname = "Person1"},
                new Player { Firstname = "Test", Lastname = "Person2"},
                new Player { Firstname = "Test", Lastname = "Person3"}
            };
        }

        public async Task<bool> AddItemAsync(Player item)
        {
            playerList.Add(item);

            return await Task.FromResult(true);
        }

       public async Task<Player> GetItemAsync(int id)
       {
           return await Task.FromResult(playerList.FirstOrDefault(s => s.Id == id));
       }

       public async Task<IEnumerable<Player>> GetItemsAsync(bool forceRefresh = false)
       {
           return await Task.FromResult(playerList);
       }
    }
}
