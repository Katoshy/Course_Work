using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Restaurantlib
{
    public interface IOrder
    {
        void Put(Meal _meal,float weight);
        void Remove(Meal _meal, float weight);
    }
    public delegate void OrderStateHandler(object sender, OrderEventArgs e); 

    public class OrderEventArgs
    {
        public string Message { get; private set; }
        public float Sum { get; private set; }

        public OrderEventArgs(string _mes, float _sum)
        {
            Message = _mes;
            Sum = _sum;
        }
    }
    public class OrderException : Exception
    {
        public OrderException(string message)
            : base(message)
        { }
    }
    public class Order : IOrder
    {
        public List<Meal> order = new List<Meal>();
        //Событие, возникающее при удалении
        protected internal event OrderStateHandler Removed;
        // Событие возникающее при добавление 
        protected internal event OrderStateHandler Puted;
        // Событие возникающее при открытии 
        protected internal event OrderStateHandler Opened;
        // Событие возникающее при закрытии
        protected internal event OrderStateHandler Closed;
        // Событие возникающее при готовке
        protected internal event OrderStateHandler Cooked;
        static int counter = 0;
        private float sum;
        public Order()
        {
            sum = 0;
            order = new List<Meal>();
            Id = ++counter;
        }
        public int Id { get; private set; }
        private void CallEvent(OrderEventArgs e, OrderStateHandler handler)
        {
            if (e != null)
                handler?.Invoke(this, e);
        }
        protected virtual void OnOpened(OrderEventArgs e)
        {
            CallEvent(e, Opened);
        }
        protected virtual void OnRemoved(OrderEventArgs e)
        {
            CallEvent(e, Removed);
        }
        protected virtual void OnPuted(OrderEventArgs e)
        {
            CallEvent(e, Puted);
        }
        protected virtual void OnClosed(OrderEventArgs e)
        {
            CallEvent(e, Closed);
        }
        protected virtual void OnCooked(OrderEventArgs e)
        {
            CallEvent(e, Cooked);
        }
        public virtual void Show()
        {
            int k = 1;
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            if (order != null)
            {
                if (order.Count == 0)
                {
                    throw new OrderException("Order is empty");
                }
                else
                {
                    Console.WriteLine("{0,-20} {1,5}\n", "Name", "Portion");
                    foreach (Meal i in order)
                    {
                        Console.WriteLine("{0} {1,-20} {2,5:N1}", k++, i.Name, i.weight);
                    }
                }
                Console.WriteLine("---------------------");
                Console.WriteLine($"| Current Sum : {this.sum} |");
                Console.WriteLine("---------------------");
                Console.ForegroundColor = color;
                Console.WriteLine();
            }
            else
            {
                throw new OrderException("Order is empty");
            }
        }
        public virtual void Put(Meal _meal,float weight)
        {
            _meal.weight = weight;
            order.Add(_meal);
            sum += _meal.PriseCalculation();
            OnPuted(new OrderEventArgs((weight*1000).ToString()+" grams portion of "+_meal.Name + $" Added to Order", sum));
        }
        public virtual void Remove(Meal _meal,float weight)
        {
            sum -= _meal.PriseCalculation();
            order.Remove(_meal);
            OnRemoved(new OrderEventArgs($"You removed " + _meal.Name + $" from your order list",sum));
        }
        protected internal virtual void Open()
        {
            OnOpened(new OrderEventArgs($"Open new Order! order's Id : {Id} ", sum));
        }
        protected internal virtual void Close()
        {
            OnClosed(new OrderEventArgs($"Order {Id} finish  , Current sum -> {sum}", sum));
        }
        protected internal virtual void Cook()
        {
            OnCooked(new OrderEventArgs($"Your order is cooking . For payment -> {sum}",sum));
        }
    }
    public class Restaurant<T> where T : Order
    {
        public List<T> orders;
        public MenuList<Meal> menu;
        public string Name { get; private set; }

        public Restaurant(string _name, MenuList<Meal> _menu)
        {
            this.Name = _name;
            this.menu = _menu;
        }
        // метод создания order
        public void Open (
            OrderStateHandler PutOrderHandler, OrderStateHandler RemoveOrderHandler,
            OrderStateHandler CookHandler, OrderStateHandler CloseOrderHandler,
            OrderStateHandler OpenOrderHandler)
        {
            T newOrder = new Order() as T;

            if (newOrder == null)
                throw new OrderException("Order is undefined");     
            if (orders == null)
                orders = new List<T>() { newOrder };
            else
            {
                orders.Add(newOrder);
            }
            newOrder.Puted += PutOrderHandler;
            newOrder.Removed += RemoveOrderHandler;
            newOrder.Closed += CloseOrderHandler;
            newOrder.Opened += OpenOrderHandler;
            newOrder.Cooked += CookHandler;
            newOrder.Open();
        }
        public void Put( int id, Meal _meal, float _weight)
        {
            if (orders[id] != null)
            {
                orders[id].Put(_meal, _weight);
                Console.WriteLine("Now your order is :");
                orders[id].Show();
            }
            else
            {
                throw new OrderException("Order not found");
            }
        }
        public void Removed(int id)
        {
            if (orders[id]!=null)
            {
                orders[id].Show();
                Console.WriteLine("Choose index of dish that you have to remove");

                int index = Convert.ToInt32(Console.ReadLine());
                if (index > 0 || orders[id].order[index-1] != null)
                {
                    orders[id].Remove(orders[id].order[index - 1], orders[id].order[index - 1].weight);
                }
                else
                {
                    throw new DishException("Unknown Dish -> index is undefined");
                }
            }
            else 
            { 
                throw new OrderException("Order not found");
            }
        }
        public void Close(int id)
        {
            T account;
            if (orders[id] != null)
            {
                account = orders[id];
            }
            else
            {
                throw new OrderException("Order not found");
            }
            account.Cook();
            account.Close();

            if (orders !=null)
            {
                orders.Remove(account);
            }
        }
    }
}
