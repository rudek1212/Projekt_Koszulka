using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoszulka
{
    public class Item
    {
        public enum SizeOfShirt
        {
            XS, S, M, L, XL, XXL, XXXL
        }

        public enum TypeOfShirt
        {
            Male, Female
        }

        private static int counter;
        private TypeOfShirt Type { get; }
        private SizeOfShirt Size { get; }
        private string Name { get; }
        internal int Id { get; set; }

        public Item()
        {
            Type = TypeOfShirt.Male;
            Size = SizeOfShirt.XL;
            Name = "WMiIShirt";
            Id = counter++;
        }

        public Item(TypeOfShirt type, SizeOfShirt size, string name)
        {
            Type = type;
            Size = size;
            Name = name;
            Id = counter++;
        }

        public override string ToString()
        {
            return Name + " " + Type + " " + Size + " " + Id;
        }
    }
}
