using Irma.Models;
using Microsoft.AspNetCore.Components;

namespace Irma.Base
{
    public class DishListBase : ComponentBase
    {
        [Parameter]
        public MenuDish[] dishes { get; set; }
    }
}
