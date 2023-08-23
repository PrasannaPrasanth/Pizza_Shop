using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Pizza_shop
{
    public class pizza_topping
    {
        string _pizza_topping;

        public string Pizza_topping
        {
            get { return _pizza_topping; }
            set { _pizza_topping = value; }
        } 
       
        public float Topping_price()
        {
           
                float amount = 0;
                foreach (var item in my_dictionary.pizza_toppings_price)
                {
                    if (my_dictionary.pizza_toppings_price.ContainsKey(Pizza_topping))
                    {
                        amount = my_dictionary.pizza_toppings_price[Pizza_topping];
                    }
                }
                return amount;
                
          
        }
        public override string ToString()
        {
            string str = "";
            str += _pizza_topping + " = " + this.Topping_price ()+ "\n";
            return str;
        }
    }
       
}
