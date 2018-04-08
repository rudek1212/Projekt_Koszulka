using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoszulka
{
    internal class Cart
    {
        public List<Item> List = new List<Item>();
        public int CustomerId { get; set; }

        //logika odpowiedzialna za dodawanie produktu do koszyka
        public void AddProduct(Item product)
        {
            List.Add(product);
            //todo cw
            Console.WriteLine("Product added");
        }

        //logika odpowiedzialna za usuwanie produktu z koszyka
        public void RemoveProduct(int id)
        {
            if (List.Count == 0)
            {
                Console.WriteLine("No products in cart"); //todo cw
            }
            else
            {
                try
                {
                    for (var i = List.Count; i > 0; i--)
                        if (List.ElementAt(i - 1).Id == id)
                        {
                            List.RemoveAt(i - 1);
                            break;
                        }
                }
                catch (Exception e)
                {
                    //todo cw
                    Console.WriteLine(e);
                    throw;
                }

                //todo cw
                Console.WriteLine("Product removed");
            }
        }

        //logoka odpowiedzialna za wyświetlanie zawartości koszyka/zamówienia (czysto na potrzeby testów konsolowych)
        public void ShowContent()
        {
            foreach (var item in List)
                //todo cw
                Console.WriteLine(item.ToString());
        }
    }
}
