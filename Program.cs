using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Restaurantlib;
namespace Restaurant_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingrideint potato = new Ingrideint("Potato");
            Ingrideint tomato = new Ingrideint("Tomato");
            Ingrideint cucumber = new Ingrideint("Cucumber");
            Ingrideint toast = new Ingrideint("Toast");
            Ingrideint onion = new Ingrideint("Onion");
            Ingrideint garlic = new Ingrideint("Garlic");
            Ingrideint salad = new Ingrideint("Salad");
            Ingrideint pasta = new Ingrideint("Pasta");
            Ingrideint milk = new Ingrideint("Milk");
            Ingrideint bacon = new Ingrideint("Bacon");
            Ingrideint salt = new Ingrideint("Salt");
            Ingrideint paper = new Ingrideint("Paper");
            Ingrideint meat = new Ingrideint("Meat");
            Ingrideint nugets = new Ingrideint("Chicken nugtes");
            Ingrideint salmon = new Ingrideint("Salmon");
            Ingrideint tuna = new Ingrideint("Tuna");
            Ingrideint pecorino = new Ingrideint("Pecorino Romano");
            Ingrideint parmesan = new Ingrideint("Parmesan");
            Ingrideint gauda = new Ingrideint("Gauda");
            Ingrideint feta = new Ingrideint("Feta");
            Ingrideint cherry = new Ingrideint("Cherry");
            Ingrideint icecream = new Ingrideint("Icecream");
            Ingrideint banana = new Ingrideint("Banana");
            Ingrideint eggs = new Ingrideint("Eggs");
            Ingrideint sugar = new Ingrideint("sugar");
            Ingrideint chocolate = new Ingrideint("Chocolate");
            Ingrideint gin = new Ingrideint("Gin");
            Ingrideint tonic = new Ingrideint("Schweppers");
            Ingrideint vodka = new Ingrideint("Vodka");
            Ingrideint cognac = new Ingrideint("Cognac");
            Ingrideint rum = new Ingrideint("Rum");
            Ingrideint water = new Ingrideint("Water");
            Ingrideint cola = new Ingrideint("Cola");
            Ingrideint wine = new Ingrideint("Wine");
            Ingrideint appelsine = new Ingrideint("Appelsine");
            Ingrideint crackers = new Ingrideint("Crackers");
            Ingrideint pineapple = new Ingrideint("Pineapple");
            Ingrideint lime = new Ingrideint("Lime");
            Ingrideint sauce = new Ingrideint("Special sauce");
            Ingrideint olives = new Ingrideint("Olives");

            Drinks _banshake = new Drinks("Banana Milkshake",120);
            _banshake.Insert(milk);
            _banshake.Insert(icecream);
            _banshake.Insert(banana);

            Drinks _milkshake = new Drinks("Milkshake", 100);
            _milkshake.Insert(milk);
            _milkshake.Insert(icecream);

            Drinks _apjuice = new Drinks("Appelsine juice",80);
            _apjuice.Insert(appelsine);

            Drinks _soda = new Drinks("Soda",25);
            _soda.Insert(tonic);

            Drinks _water = new Drinks("Water", 25);
            _water.Insert(water);

            Drinks _gintonic = new Drinks("Gin Tonic",350);
            _gintonic.Insert(tonic);
            _gintonic.Insert(gin);

            Drinks _libre = new Drinks("Cuba-Libre",250);
            _libre.Insert(cola);
            _libre.Insert(rum);

            Drinks _clicquot= new Drinks("Veuve Clicquot", 700);
            _clicquot.Insert(wine);

            Drinks _stolychnaya= new Drinks("Stolychnaya",85);
            _stolychnaya.Insert(vodka);

            Appetizer  _snadwichF = new Appetizer("Fish-Sandwich", 200);
            _snadwichF.Insert(toast);
            _snadwichF.Insert(tuna);
            _snadwichF.Insert(tomato);
            _snadwichF.Insert(paper);
            _snadwichF.Insert(salt);
            _snadwichF.Insert(salad);
            _snadwichF.Insert(onion);

            Appetizer  _snadwichB = new Appetizer("Bacon-Sandwich",_snadwichF, 200);
            _snadwichB.Remove(tuna);
            _snadwichB.Insert(bacon);

            Appetizer _snadwichV = new Appetizer("Vegeterian-Sandwich", _snadwichB, 200);
            _snadwichV.Remove(bacon);
            _snadwichV.Insert(eggs);

            Appetizer _caesar = new Appetizer("Caesar Salad",320);
            _caesar.Insert(crackers);
            _caesar.Insert(salad);
            _caesar.Insert(tomato);
            _caesar.Insert(parmesan);
            _caesar.Insert(sauce);
            _caesar.Insert(paper);
            _caesar.Insert(salt);

            Appetizer _greek = new Appetizer("Greek Salad",300);
            _greek.Insert(tomato);
            _greek.Insert(cucumber);
            _greek.Insert(feta);
            _greek.Insert(onion);
            _greek.Insert(olives);
            _greek.Insert(paper);
            _greek.Insert(salt);

            Dish _lasagnya = new Dish("Lasagnya",400);
            _lasagnya.Insert(pasta);
            _lasagnya.Insert(tomato);
            _lasagnya.Insert(potato);
            _lasagnya.Insert(meat);
            _lasagnya.Insert(sauce);
            _lasagnya.Insert(gauda);
            _lasagnya.Insert(parmesan);
            _lasagnya.Insert(salt);
            _lasagnya.Insert(paper);

            Dish _carbonara = new Dish("Spaghetti Carbonara",400);
            _carbonara.Insert(pasta);
            _carbonara.Insert(bacon);
            _carbonara.Insert(garlic);
            _carbonara.Insert(eggs);
            _carbonara.Insert(pecorino);
            _carbonara.Insert(paper);
            _carbonara.Insert(salt);


            Dish _chicknug = new Dish("Chicken nugets", 260);
            _chicknug.Insert(nugets);
            _chicknug.Insert(crackers);
            _chicknug.Insert(paper);
            _chicknug.Insert(salt);
            _chicknug.Insert(sauce);

            Dessert _frice = new Dessert("Fruit IceCream", 200);
            _frice.Insert(icecream);
            _frice.Insert(banana);
            _frice.Insert(pineapple);
            _frice.Insert(lime);
            _frice.Insert(sauce);

            Dessert _chice = new Dessert("Chocolate IceCream", 200);
            _chice.Insert(icecream);
            _chice.Insert(chocolate);
            _chice.Insert(sauce);

            MenuList<Meal> menu = new MenuList<Meal>("Cheaf menu");
            menu.Add(_libre);
            menu.Add(_gintonic);
            menu.Add(_clicquot);
            menu.Add(_banshake);
            menu.Add(_milkshake);
            menu.Add(_soda);
            menu.Add(_water);
            menu.Add(_apjuice);
            menu.Add(_stolychnaya);
            menu.Add(_chice);
            menu.Add(_snadwichF);
            menu.Add(_snadwichB);
            menu.Add(_snadwichV);
            menu.Add(_greek);
            menu.Add(_caesar);
            menu.Add(_lasagnya);
            menu.Add(_carbonara);
            menu.Add(_frice);
            Restaurant<Order> restaurant = new Restaurant<Order>("ClaudeMonet",menu);
            Console.WriteLine($"Welcome to {restaurant.Name}!");
            Console.WriteLine("Please take your reservations!");

            bool alive = true;
            while (alive)
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("1. Create order");
                Console.WriteLine("2. Add to order");
                Console.WriteLine("3. Remove from order");
                Console.WriteLine("4. Close order");
                Console.WriteLine("5. Show order");
                Console.WriteLine("6. Exit");
                try
                {
                    int command = Convert.ToInt32(Console.ReadLine());
                    switch (command)
                    {
                        case 1:
                            OpenOrder(restaurant);
                            break;
                        case 2:
                            AddToOrder(restaurant);
                            break;
                        case 3:
                            RemoveInOrder(restaurant);
                            break;
                        case 4:
                            CloseOrder(restaurant);
                            break;
                        case 5:
                            ShowOrder(restaurant);
                            break;
                        case 6:
                            alive = false;
                            continue;
                    }
                }
                catch(Exception ex)
                {
                    color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = color;
                }
            }
        }
        private static void OpenOrder(Restaurant<Order> rest)
        {
            Console.WriteLine("");
            rest.Open
                (PutOrderHandler,
                RemoveOrderHandler,
                CookHandler,
                CloseOrderHandler,
                OpenOrderHandler);
        }
        private static void ShowOrder(Restaurant<Order> rest)
        {
            Console.WriteLine("Enter id of order:");
            int id = Convert.ToInt32(Console.ReadLine());
            rest.orders[id-1].Show();
        }
        private static void RemoveInOrder(Restaurant<Order> rest)
        {
            Console.WriteLine("Enter id of order:");
            int id = Convert.ToInt32(Console.ReadLine());
            rest.Removed(id-1);
        }
        private static void CloseOrder(Restaurant<Order> rest)
        {
            Console.WriteLine("Enter id of order:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your finaly order :");
            rest.orders[id - 1].Show();
            rest.Close(id-1);
        }
        private static void AddToOrder(Restaurant<Order> rest)
        {
            Console.WriteLine("Enter id of order:");
            int id = Convert.ToInt32(Console.ReadLine());
            id--;
            if (rest.orders[id] != null)
            {
                Console.WriteLine("Choose menu category :");
                Console.WriteLine("1. Appertizes \t 2. Main Dishes \t 3. Desserts \t 4. Drinks");
                ConsoleColor color = Console.ForegroundColor;
                int category = Convert.ToInt32(Console.ReadLine());
                switch (category)
                {
                    case 1:
                        int i = 1;
                        foreach (Meal meal in rest.menu.appertize)
                        {
                            Console.WriteLine("{0} {1,-20} {2,5:N1}/kg", i++, meal.Name, meal.Cost);
                        }
                        Console.WriteLine("Your choose : ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Composition : ");
                        Console.WriteLine(rest.menu.appertize[index - 1].Recipe);
                        Console.ForegroundColor = color;
                        Console.WriteLine("Choose portion : ");
                        for (int k = 0; k < 3; k++)
                        {
                            Console.WriteLine($"{k + 1}. {portion[k]} kg");
                        }
                        Console.WriteLine("4. Cancle");
                        int ind = Convert.ToInt32(Console.ReadLine());
                        if (ind != 4)
                        {
                            float weight = portion[ind - 1];
                            rest.Put(id, rest.menu.appertize[index - 1], weight);
                        }
                        break;
                    case 2:
                        i = 1;
                        foreach (Meal meal in rest.menu.dish)
                        {
                            Console.WriteLine("{0} {1,-20} {2,5:N1}/kg", i++, meal.Name, meal.Cost);
                        }
                        Console.WriteLine("Your choose : ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Composition : ");
                        Console.WriteLine(rest.menu.dish[index - 1].Recipe);
                        Console.ForegroundColor = color;
                        Console.WriteLine("Choose portion : ");
                        for (int k = 0; k < 3; k++)
                        {
                            Console.WriteLine($"{k + 1}. {portion[k]} kg");
                        }
                        Console.WriteLine("4. Cancle");
                        ind = Convert.ToInt32(Console.ReadLine());
                        if (ind != 4)
                        {
                            float weight = portion[ind - 1];
                            rest.Put(id, rest.menu.dish[index - 1], weight);
                        }
                        break;
                    case 3:
                        i = 1;
                        foreach (Meal meal in rest.menu.dessert)
                        {
                            Console.WriteLine("{0} {1,-20} {2,5:N1}/kg", i++, meal.Name, meal.Cost);
                        }
                        Console.WriteLine("Your choose : ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Composition : ");
                        Console.WriteLine(rest.menu.dessert[index - 1].Recipe);
                        Console.ForegroundColor = color;
                        Console.WriteLine("Choose portion : ");
                        for (int k = 0; k < 3; k++)
                        {
                            Console.WriteLine($"{k + 1}. {portion[k]} kg");
                        }
                        Console.WriteLine("4. Cancle");
                        ind = Convert.ToInt32(Console.ReadLine());
                        if (ind != 4)
                        {
                            float weight = portion[ind - 1];
                            rest.Put(id, rest.menu.dessert[index - 1], weight);
                        }
                        break;
                    case 4:
                        i = 1;
                        foreach (Meal meal in rest.menu.drinks)
                        {
                            Console.WriteLine("{0} {1,-20} {2,5:N1}/l", i++, meal.Name, meal.Cost);
                        }
                        Console.WriteLine("Your choose : ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Composition : ");
                        Console.WriteLine(rest.menu.drinks[index - 1].Recipe);
                        Console.ForegroundColor = color;
                        Console.WriteLine("Choose portion : ");
                        for (int k=0;k<3;k++)
                        {
                            Console.WriteLine($"{k+1}. {portion[k]} kg");
                        }
                        Console.WriteLine("4. Cancle");
                        ind = Convert.ToInt32(Console.ReadLine());
                        if (ind != 4)
                        {
                            float weight = portion[ind - 1];
                            rest.Put(id, rest.menu.drinks[index - 1], weight);
                        }
                        break;
                }
            }
            else
            {
                throw new OrderException("Order is undefined");
            }
        }
        static float[] portion = new float[3] {1.0f, 0.5f, 0.2f };
        private static void OpenOrderHandler(object sender, OrderEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
        private static void PutOrderHandler(object sender, OrderEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
        private static void RemoveOrderHandler(object sender, OrderEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
        private static void CookHandler(object sender, OrderEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
        private static void CloseOrderHandler(object sender, OrderEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}