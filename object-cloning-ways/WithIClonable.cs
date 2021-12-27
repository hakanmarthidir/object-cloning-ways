using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_cloning_ways
{
    //Method 1 : IClonable
    public class Category : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return (Category)MemberwiseClone();
        }
    }


    public class Product : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public List<string> Actions { get; set; }

        public object Clone()
        {
            Product product = (Product)MemberwiseClone();
            product.Category = (Category)this.Category.Clone();
            product.Actions = new List<string>();
            return product;
        }
    }
}
