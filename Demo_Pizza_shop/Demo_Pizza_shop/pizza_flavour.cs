using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Pizza_shop
{
   public class pizza_flavour
    {
        string _pizza_flavour;

        public string Pizza_flavour
        {
            get { return _pizza_flavour; }
            set { _pizza_flavour = value; }
        }

       
        public float Flavour_price()
        {
                float amount = 0;
               
                foreach (var item in my_dictionary.pizza_flavours_price)
                {
                    if (my_dictionary.pizza_flavours_price.ContainsKey(Pizza_flavour))
                    {
                        amount = my_dictionary.pizza_flavours_price[Pizza_flavour];
                    }
                }
                return amount;
                 
        }
        public override string ToString()
        {
            string str = string.Empty;
            str = _pizza_flavour + " = " + this.Flavour_price() + "\n";
            return str;
        }
    }
   
}
