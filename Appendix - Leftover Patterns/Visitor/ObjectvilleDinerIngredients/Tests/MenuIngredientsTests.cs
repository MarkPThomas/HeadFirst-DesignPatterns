using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjectvilleDinerIngredients.Model;
using Menus.Model;

namespace ObjectvilleDinerIngredients.Tests
{
    public class MenuIngredientsTests
    {
        public static void Run()
        {
            // Create Pancake House Menu
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "BreakFast");
            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast",
                    "Pancakes with scrambled eggs, and toast.",
                    true,
                    2.99,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Pancakes", HealthRating.D, 300, 20, 45),
                        new MenuIngredient("Scrambled Eggs", HealthRating.A, 200, 80, 0),
                        new MenuIngredient("Toast", HealthRating.B, 100, 5, 25)}));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast",
                    "Pancakes with fried eggs, sausage.",
                    false,
                    2.99,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Pancakes", HealthRating.D, 300, 20, 45),
                        new MenuIngredient("Fried Eggs", HealthRating.A, 250, 80, 0),
                        new MenuIngredient("Sausage", HealthRating.B, 100, 25, 25)}));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes",
                    "Pancakes made with fresh blueberries.",
                    true,
                    3.49,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Pancakes", HealthRating.D, 300, 20, 45),
                        new MenuIngredient("Blueberries", HealthRating.A, 50, 5, 10)}));
            pancakeHouseMenu.Add(new MenuItem("Waffles",
                    "Waffles, with your choice of blueberries or strawberries.",
                    true,
                    3.59,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Waffles", HealthRating.D, 320, 25, 45),
                        new MenuIngredient("Blueberries", HealthRating.A, 50, 5, 10),
                        new MenuIngredient("Strawberries", HealthRating.A, 50, 5, 10)}));

            // Create Diner Menu
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            dinerMenu.Add(new MenuItem("Vegetarian BLT",
                    "(Fakin') Bacon with lettuce & tomato on whole wheat.",
                    true,
                    2.99,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Bacon Substitute", HealthRating.B, 100, 20, 0),
                        new MenuIngredient("Lettuce", HealthRating.A, 30, 0, 0),
                        new MenuIngredient("Tomato", HealthRating.A, 50, 0, 10),
                        new MenuIngredient("Whole Wheat Bread", HealthRating.A, 100, 5, 25)}));
            dinerMenu.Add(new MenuItem("BLT",
                    "Bacon with lettuce & tomato on whole wheat.",
                    false,
                    2.99,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Bacon", HealthRating.C, 130, 30, 0),
                        new MenuIngredient("Lettuce", HealthRating.A, 30, 0, 0),
                        new MenuIngredient("Tomato", HealthRating.A, 50, 0, 10),
                        new MenuIngredient("Whole Wheat Bread", HealthRating.A, 100, 5, 25)}));
            dinerMenu.Add(new MenuItem("Soup of the Day",
                    "Soup of the day, with a side of potato salad.",
                    false,
                    3.29,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Soup", HealthRating.B, 100, 20, 45),
                        new MenuIngredient("Potato Salad", HealthRating.B, 200, 0, 80)}));
            dinerMenu.Add(new MenuItem("Hotdog",
                    "A hot dog with saurkraut, relish, onions, topped with cheese.",
                    false,
                    3.05,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Hot Dog", HealthRating.D, 100, 20, 45),
                        new MenuIngredient("Saurkraut", HealthRating.C, 50, 80, 0),
                        new MenuIngredient("Relish", HealthRating.B, 20, 6, 2),
                        new MenuIngredient("Onions", HealthRating.B, 10, 7, 2),
                        new MenuIngredient("Cheese", HealthRating.B, 50, 5, 5),
                        new MenuIngredient("Bun", HealthRating.B, 60, 5, 35)}));
            dinerMenu.Add(new MenuItem("Steamed Veggies and Brown Rice",
                    "Steamed vegetables over brown rice.",
                    true,
                    3.99,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Steamed Veggies", HealthRating.A, 130, 5, 15),
                        new MenuIngredient("Brown Rice", HealthRating.A, 100, 10, 20)}));
            dinerMenu.Add(new MenuItem("Pasta",
                    "Spaghetti with Marinara Sauce, and a slice of sourdough bread.",
                    true,
                    3.89,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Spaghetti", HealthRating.A, 120, 0, 55),
                        new MenuIngredient("Marinara Sauce", HealthRating.C, 100, 20, 0),
                        new MenuIngredient("Sourdough Bread", HealthRating.B, 100, 5, 25)}));

            // Create Cafe Menu
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries",
                    "Veggie burger on a whole wheat bun, lettuce, tomato, and fries.",
                    true,
                    3.99,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Bun", HealthRating.B, 110, 0, 45),
                        new MenuIngredient("veggie Paddie", HealthRating.C, 200, 80, 0),
                        new MenuIngredient("Air Fries", HealthRating.D, 100, 5, 25)}));
            cafeMenu.Add(new MenuItem("Soup of the Day",
                    "A cup of the soup of the day, with a side salad.",
                    false,
                    3.69,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Soup of the Day", HealthRating.A, 120, 20, 45),
                        new MenuIngredient("Salad", HealthRating.A, 100, 0, 0)}));
            cafeMenu.Add(new MenuItem("Burrito",
                    "A large burrito, with whole pinto beans, salsa, guacamole.",
                    true,
                    4.29,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Rice", HealthRating.A, 100, 0, 50),
                        new MenuIngredient("Pinto Beans", HealthRating.B, 100, 40, 0),
                        new MenuIngredient("Salsa", HealthRating.C, 10, 5, 0),
                        new MenuIngredient("Guacamole", HealthRating.C, 15, 5, 0),
                        new MenuIngredient("Taco Bread", HealthRating.B, 80, 5, 25)}));

            // Create Dessert Menu
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert, of course!");
            dessertMenu.Add(new MenuItem("Apple Pie",
                    "Apple pie with flakey crust, topped with vanilla ice cream.",
                    true,
                    1.59,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Apple", HealthRating.A, 100, 20, 45),
                        new MenuIngredient("Crust", HealthRating.C, 300, 80, 0)}));
            dessertMenu.Add(new MenuItem("Cheesecake",
                    "Creamy New York cheesecake, with a chocolate graham crust..",
                    true,
                    1.99,
                    new List<MenuIngredient>() {
                        new MenuIngredient("Cheese", HealthRating.B, 80, 50, 5),
                        new MenuIngredient("Milk", HealthRating.A, 100, 20, 10),
                        new MenuIngredient("Chocolate", HealthRating.B, 100, 5, 25)}));
            dessertMenu.Add(new MenuItem("Sorbet",
                    "A scoop of raspberry and a scoop of lime.",
                    true,
                    1.89,
                    new List<MenuIngredient>() { 
                        new MenuIngredient("Milk", HealthRating.A, 100, 20, 10),
                        new MenuIngredient("Sugar", HealthRating.D, 100, 0, 0)}));

            // Combine Menus
            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined.");

            allMenus.Add(pancakeHouseMenu);

            allMenus.Add(dinerMenu);
            dinerMenu.Add(dessertMenu);

            allMenus.Add(cafeMenu);

            Visitor ingredientVisitor = new Visitor();
            allMenus.Accept(ingredientVisitor);
        }
    }
}
