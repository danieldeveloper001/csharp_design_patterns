using System;
using System.Collections.Generic;

namespace Project
{

    // TODO: CONSIDER SEPARATE MENUS
    public class Menu
    {
        public IList<MenuItem> Drinks { get; private set; }
        public IList<MenuItem> Meals { get; private set; }
        public IList<MenuItem> Deserts { get; private set; }

        public Menu()
        {
            AddMenuDrinks();
            AddMenuMeals();
            AddMenuDeserts();
        }

        private void AddMenuDrinks()
        {
            Drinks = new List<MenuItem>();
            Drinks.Add(new MenuItem("Orange Juice"));
            Drinks.Add(new MenuItem("Lemon Juice"));
            Drinks.Add(new MenuItem("Strawberry Juice"));
            Drinks.Add(new MenuItem("Pineaple Juice"));
            Drinks.Add(new MenuItem("Apple Juice"));
        }

        private void AddMenuMeals()
        {
            Meals = new List<MenuItem>();
            Meals.Add(new MenuItem("Rice, Beans, Beef and French Fries"));
            Meals.Add(new MenuItem("Rice, Beans, Beef and Salad"));
            Meals.Add(new MenuItem("Rice, Beans, Chicken and French Fries"));
            Meals.Add(new MenuItem("Rice, Beans, Chicken and Salad"));
            Meals.Add(new MenuItem("Rice, Beans, Fish and Salad"));
        }

        private void AddMenuDeserts()
        {
            Deserts = new List<MenuItem>();
            Deserts.Add(new MenuItem("Chocolate Ice Cream"));
            Deserts.Add(new MenuItem("Vanilla Ice Cream"));
        }
    }
}