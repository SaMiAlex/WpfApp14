using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14
{
    public enum ProductTypes
    {
        Electronic,
        Food
    }

    public class Product
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        public ProductTypes ProductType { get; set; }

        //public override string ToString()
        //{
        //    return ProblemName;
        //}
    }
}
