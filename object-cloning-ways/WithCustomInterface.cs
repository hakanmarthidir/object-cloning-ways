using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_cloning_ways
{
    //Method 2 : Custom Interface
    public interface ICloneType<T>
    {
        T Clone();
    }

    
    public class Country: ICloneType<Country>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Country Clone()
        {
            return (Country)MemberwiseClone();
        }
    }

    public class City : ICloneType<City>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }

        public City Clone()
        {
            City clone = (City)MemberwiseClone();
            clone.Country= (Country)this.Country.Clone();
            return clone;
        }
    }
}
