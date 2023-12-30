using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servise
{
    public interface ICityServise
    {
        public List<City> GetCities();
        public City AddCity(City cityName);
        public void DeleteCity(int id);
        public City Update(int id, City city);
        public City GetId(int id);
    }
}
