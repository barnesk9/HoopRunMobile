using System.Collections.Generic;
using System.Threading.Tasks;
using MyApp1.Models;

namespace MyApp1.Services.Interfaces
{
    public interface IRestService
    {
        Task<List<object>> RefreshDataAsync();

        Task GetPlayerAsync(Player player, bool isNewItem);

        Task DeleteTodoItemAsync(string id);
    }
}
