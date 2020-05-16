using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurant = new Restaurant();

            restaurant.AddMenu(new Menu());

            restaurant.AddCook(new Cook("Dino"));
            restaurant.AddCook(new Cook("Kōyō"));

            restaurant.AddWaiter(new Waiter("Maika"));
            restaurant.AddWaiter(new Waiter("Kaho"));
            restaurant.AddWaiter(new Waiter("Mafuyu"));
            restaurant.AddWaiter(new Waiter("Miu"));
            restaurant.AddWaiter(new Waiter("Hideri"));

            restaurant.Serve(new Customer("Kirito"));
            restaurant.Serve(new Customer("Asuna"));
            restaurant.Serve(new Customer("Shinon"));
        }
    }
}
