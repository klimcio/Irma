using Irma.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Irma.Base
{
    public class RestaurantMenuBase : ComponentBase
    {
        public MenuDish[] menuDishes;

        [Inject]
        protected HttpClient httpClient { get; set; }

        protected override async Task OnInitializedAsync()
        {
            menuDishes = await httpClient.GetFromJsonAsync<MenuDish[]>("data/menu.json");
        }
    }
}
