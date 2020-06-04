using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Ingrideint
    {
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Ingrideint(String name)
        {
            this.Name = name;
        }
        protected String name;
    }

    public class DishException : Exception
    {
        public DishException(string message)
            : base(message)
        { }
    }
    public abstract class Meal
    {
        protected String recipe;
        public String type;
        protected float cost;
        public float weight;
        public String Name { protected set; get; }
        public String Recipe
        {
            protected set
            {
                recipe = value;
            }
            get
            {
                if (recipe == null)
                {
                    throw new DishException("Empty Dish");
                }
                return recipe;
            }
        }
        public float Cost
        {
            get { return cost; }
            set 
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                {
                    throw new DishException("Cost can't be not positive");
                }
            }
        }
        public List<Ingrideint> list = new List<Ingrideint>();
        public Meal(String _name,float _cost)
        {
            cost = _cost;
            Name = _name;
        }
        public void Insert(Ingrideint i)
        {
            list.Add(i);
            recipe += i.Name + " , ";
        }
        public void Insert(Ingrideint[] i)
        {
            list.AddRange(i);
            foreach(Ingrideint x in i )
                recipe += x.Name + " , ";
        }
        public void Remove(Ingrideint i)
        {
            if (list.Contains(i))
            {
                list.Remove(i);
                String substr = i.Name + " , ";
                recipe = recipe.Replace(i.Name + " , ","");
            }
            else
            {
                throw new DishException("Ingridient is none contain");
            }
        }
        public float PriseCalculation()
        {
            float sum = weight * Cost;
            return sum;
        }
    }
    public class Appetizer : Meal
    {
        public Appetizer(String _name,float _cost) : base(_name, _cost) { type = "Appertize"; recipe = "The Appetizer "+ Name+" : "; }
        public Appetizer(String _name,Appetizer cpy, float _cost) : base(_name, _cost) 
        {
            type = "Appertize";
            recipe = "The Appetizer " + Name + " : "; 
            foreach(Ingrideint i in cpy.list)
            {
                this.list.Add(i);
                this.recipe += i.Name + " , ";
            }
        }
    }
    public class Dessert : Meal
    {
        public Dessert(String _name, float _cost) : base(_name, _cost) { type = "Dessert"; recipe = "The Dessert " + Name + " : "; }
        public Dessert(String _name, Appetizer cpy, float _cost) : base(_name, _cost)
        {
            type = "Dessert";
            recipe = "The Dessert " + Name + " : ";
            foreach (Ingrideint i in cpy.list)
            {
                this.list.Add(i);
                this.recipe += i.Name + " , ";
            }
        }
    }
    public class Dish : Meal
    {
        public Dish(String _name, float _cost) : base(_name, _cost) { type = "Dish"; recipe = "The Dish " + Name + " : "; }
        public Dish(String _name, Appetizer cpy, float _cost) : base(_name, _cost)
        {
            type = "Dish";
            recipe = "The Dish " + Name + " : ";
            foreach (Ingrideint i in cpy.list)
            {
                this.list.Add(i);
                this.recipe += i.Name + " , ";
            }
        }
    }
    public class Drinks : Meal
    {
        public Drinks(String _name, float _cost) : base(_name, _cost) { type = "Drinks"; recipe = "The Drinks " + Name + " : "; }
        public Drinks(String _name, Appetizer cpy, float _cost) : base(_name, _cost)
        {
            type = "Drinks";
            recipe = "The Drinks " + Name + " : ";
            foreach (Ingrideint i in cpy.list)
            {
                this.list.Add(i);
                this.recipe += i.Name + " , ";
            }
        }
    }





    public class MenuException : Exception
    {
        public MenuException(string message)
            : base(message)
        { }
    }
    public class MenuList<M> where M : Meal
    {
        public List<M> appertize = new List<M>();
        public List<M> dessert = new List<M>();
        public List<M> dish = new List<M>();
        public List<M> drinks = new List<M>(); 
        public String Name { set; get; }
        public MenuList(String _name)
        {
            Name = _name;
        }
        public void Add(M _meal)
        {
            if (_meal.type == "Appertize")
                appertize.Add(_meal);
            else
                if (_meal.type == "Dessert")
                    dessert.Add(_meal);
            else
                if (_meal.type == "Dish")
                    dish.Add(_meal);
            else
                if (_meal.type == "Drinks")
                    drinks.Add(_meal);
        }
        public void Remove(M _meal)
        {
            if (appertize.Contains(_meal))
                appertize.Remove(_meal);
            else
                if (dessert.Contains(_meal))
                    dessert.Remove(_meal);
            else
                if (dish.Contains(_meal))
                    dish.Remove(_meal);
            else
                if (drinks.Contains(_meal))
                    drinks.Remove(_meal);
            else
            {
                throw new MenuException("The dish is none contain");
            }
        }
    }
}
