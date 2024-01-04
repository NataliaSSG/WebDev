using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace tarea_superheroe.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string nombre { get; set; }

    [BindProperty]
    public int mes { get; set; }

    public string nombreUnicornio { get; set; }
    public bool formSubmitted { get; set; }
    public bool showImage { get; set; }


    public void OnGet()
    {
        ViewData["MensajeError"] = "";
        formSubmitted = false;
    }

    public Dictionary<char, string> diccionarioNombre = new Dictionary<char, string>
    {
            {'a', "Twinkle"},
            {'b', "Bubbles"},
            {'c', "Merry"},
            {'d', "Shiny"},
            {'e', "Sparkly"},
            {'f', "Summer"},
            {'g', "Lollipop"},
            {'h', "Lady"},
            {'i', "Pinkie"},
            {'j', "Jolly"},
            {'k', "Colorful"},
            {'l', "Honey"},
            {'m', "Dreamy"},
            {'n', "Crazy"},
            {'o', "Marshmallow"},
            {'p', "Starlight"},
            {'q', "Silly"},
            {'r', "Purple"},
            {'s', "Miss"},
            {'t', "Princess"},
            {'u', "Queen"},
            {'v', "Little"},
            {'w', "Sweetie"},
            {'x', "Fancy"},
            {'y', "Buttercup"},
            {'z', "Sassy"}
     };

    public Dictionary<int, string> diccionarioMes = new Dictionary<int, string>
    {
            {1, "Bright Eyes"},
            {2, "Giggles"},
            {3, "Rainbow Hair"},
            {4, "Happy Hooves"},
            {5, "Jelly Belly"},
            {6, "Bubbles"},
            {7, "Nightsky"},
            {8, "Sunshine"},
            {9, "Silver Moon"},
            {10, "Flower Bloom"},
            {11, "Glitter Love"},
            {12, "Candy"}
    };


    public void OnPost()
    {
        char primeraLetra = nombre[0];
        bool esLetra = char.IsLetter(primeraLetra);

        formSubmitted = true;
        if (esLetra)
        {
            primeraLetra = char.ToLower(primeraLetra);
            ViewData["textito"] = "Tu nombre es: ";
            nombreUnicornio = diccionarioNombre[primeraLetra] + " " + diccionarioMes[mes];
            showImage = true;
        }

        else
        {
            ViewData["MensajeError"] = "Error: Introduce datos validos.";
            showImage = false;
        }
    }
}

