using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Pizza_shop;
namespace Console_pizza_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            my_dictionary.Load_dictionary();
            pizza_structure ps = new pizza_structure();
            string size_input = "Extralarge";
            if (Enum.IsDefined(typeof(pizza_sizes), size_input))
            {
                pizza_sizes temp = (pizza_sizes)Enum.Parse(typeof(pizza_sizes), size_input);
                ps.Pizza_size = temp;
            }
            else
            {
                throw new Exception("This size is not here");
            }

            string base_input = "Thickcrust";

            if (Enum.IsDefined(typeof(pizza_bases), base_input))
            {
                pizza_bases temp = (pizza_bases)Enum.Parse(typeof(pizza_bases), base_input);
                ps.Pizza_base = temp;
            }
            else
            {
                throw new Exception("This base is not here");

            }

            string type_input = "Veg";
            if (Enum.IsDefined(typeof(pizza_types), type_input))
            {
                pizza_types parse = (pizza_types)Enum.Parse(typeof(pizza_types), type_input);
                ps.Pizza_type = parse;
            }
            else
            {
                throw new Exception("This size is not here");
            }
           
           
           
          
            
            
            pizza_flavour flav1 = new pizza_flavour();
            flav1.Pizza_flavour = "Pepperoni";
            pizza_flavour flav2 = new pizza_flavour();
            flav2.Pizza_flavour = "Broccoli";
            
            pizza_topping pt1 = new pizza_topping();
            pt1.Pizza_topping = "Black olives";
            pizza_topping pt2 = new pizza_topping();
            pt2.Pizza_topping = "Golden corn";
            pizza_topping pt3 = new pizza_topping();
            pt3.Pizza_topping = "Red pepper";
            pizza_topping pt4 = new pizza_topping();
            pt4.Pizza_topping = "Mushroom";
           
            Bill bi = new Bill();
            bi.Pizza = ps;
            bi.Flavours.Add(flav1);
            bi.Flavours.Add(flav2);
            bi.Toppings.Add(pt1);
            bi.Toppings.Add(pt2);
            bi.Toppings.Add(pt3);
            bi.Toppings.Add(pt4);
            Console.WriteLine(bi);
        
        }
    }
}
