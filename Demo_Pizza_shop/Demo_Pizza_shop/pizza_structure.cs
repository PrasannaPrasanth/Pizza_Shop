using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Pizza_shop
{
    public class pizza_structure
    {
        pizza_sizes _pizza_size;

        public pizza_sizes Pizza_size
        {
            get { return _pizza_size; }
            set { _pizza_size = value; }
        }
        pizza_bases _pizza_base;
        pizza_types _pizza_type;
       

        public pizza_bases Pizza_base
        {
            get { return _pizza_base; }
            set { _pizza_base = value;}
        }

      
        public pizza_types Pizza_type
        {
            get { return _pizza_type; }
            set { _pizza_type = value; }
        }
       

        private float Base_price
        {
            get {
                float amount = 0;
               
                foreach (var item in my_dictionary.pizza_structure_price)
                {
                    if (my_dictionary.pizza_structure_price.ContainsKey(Pizza_base.ToString()))
                    {
                        amount = my_dictionary.pizza_structure_price[Pizza_base.ToString()];
                    }
                }
                return amount;
                }
           
        }

        private float Size_price
        {
            get {
                float amount = 0;
                foreach (var item in my_dictionary.pizza_structure_price)
                {
                    if (my_dictionary.pizza_structure_price.ContainsKey(Pizza_size.ToString()))
                    {
                        amount = my_dictionary.pizza_structure_price[Pizza_size.ToString()];
                    }
                }
                return amount;
                }
            
        }

      
        

        public float Structure_price()
        {
            float temp = Base_price + Size_price;
            return temp;
        }
        public override string ToString()
        {
            string str = string.Empty;
            str += "pizza base : " + this.Pizza_base+" = "+this.Base_price+"\n";
            str += "pizza size : " + this.Pizza_size+" = "+this.Size_price+"\n";
            str += "pizza type : " + this.Pizza_type+"\n";
            return str;
        }
       
    }
    public  enum pizza_sizes
    {
        Large,
        Regular,
        Extralarge,
    }
    public enum pizza_bases
    { 
        Regular,
        Thincrust,
        Thickcrust,
    }
    public enum pizza_types
    { 
        Veg,
        Nonveg,
    }
}
