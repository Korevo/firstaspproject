using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {

            new PizzasModel() {
                ImageTittle="Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4
            },

            new PizzasModel() {
                ImageTittle="Bolognese",
                PizzaName="Bolognese",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                FinalPrice=5
            },

            new PizzasModel() {
                ImageTittle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                Pineapple=true,
                Cheese=true,
                Ham=true,
                FinalPrice=15
            },

            new PizzasModel() {
                ImageTittle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Mushroom=true,
                FinalPrice=6
            },

            new PizzasModel() {
                ImageTittle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Beef=true,
                Peperoni=true,
                FinalPrice=9
            },

            new PizzasModel() {
                ImageTittle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice=5
            },

            new PizzasModel() {
                ImageTittle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Peperoni=true,
                FinalPrice=5
            },

            new PizzasModel() {
                ImageTittle="Seafood",
                PizzaName="Seafood",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Tuna=true,
                FinalPrice=6
            },

            new PizzasModel() {
                ImageTittle="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                Pineapple=true,
                FinalPrice=12
            }

        };
        public void OnGet()
        {
        }
    }
}
