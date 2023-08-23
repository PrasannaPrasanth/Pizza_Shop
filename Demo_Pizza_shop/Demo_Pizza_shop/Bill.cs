using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Pizza_shop
{
   public class Bill
    {
        pizza_structure pizza;

        public pizza_structure Pizza
        {
            get { return pizza; }
            set { pizza = value; }
        }
        List<pizza_flavour> flavours = new List<pizza_flavour>(2);

        public List<pizza_flavour> Flavours
        {
            get { return flavours; }
            set { flavours = value; }
        }

        List<pizza_topping> toppings=new List<pizza_topping>(4);

        public List<pizza_topping> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public void Add_flavour(string flav)
        {
            Flavours.Add(new pizza_flavour() {Pizza_flavour=flav });
        }
        public void Remove_flavour(string flav)
        {
            foreach (var item in flavours )
            {
                if (flav == item.Pizza_flavour)
                {
                    flavours.Remove(item);
                }
            }
        }
        public void Add_topping(string topping)
        {
           toppings.Add(new pizza_topping() {Pizza_topping=topping });
        }
        public void Remove_topping(string topping)
        {
            foreach (var item in toppings)
            {
                if (topping == item.Pizza_topping)
                {
                    toppings.Remove(item);
                }
            }
        }
        private float flavourprice()
        {
            float temp = 0;
            foreach (pizza_flavour item in flavours)
            {
                temp += item.Flavour_price();
            }
            return temp;
        }
        private float toppingprice()
        {
            float temp = 0;
            foreach (pizza_topping item in toppings)
            {
                temp += item.Topping_price();
            }
            return temp;
        }
        public float Total_price()
        {
            return Pizza.Structure_price() + flavourprice() + toppingprice();
        }
        public override string ToString()
        {
            string str = string.Empty;
            str += pizza.ToString() + "\n";
            str += "Pizza Flavours : "+"\n"+"\n";
            foreach (pizza_flavour item in flavours)
            {
                str +=item.ToString();
            }
            str += "\n";
            str += "Pizza Toppings : "+"\n"+"\n";
            foreach (pizza_topping item in toppings)
            {
                str += item.ToString();
            }
            str += "\n";
            str += "Total amount = " + Total_price();
            return str;
        }
    }
}
