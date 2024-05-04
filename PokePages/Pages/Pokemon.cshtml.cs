using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PokePages.Pages
{
    public class PokemonModel : PageModel
    {

        [BindProperty(SupportsGet =true)]
        public string Pokemon { get; set; }

        public void OnGet()
        {
            if (Pokemon == null)
            {
                Pokemon = "bulbasaur";
            }
            Pokemon = Pokemon.ToLower();
        }
    }
}
