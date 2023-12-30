using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repository
{
    public interface ICityRepository
    {
        public List<City> GetAllCity();
        public City AddCity(City city);
        public City Update(int id, City city);
        public void DeleteCity(int id);
        public City GetId(int id);
    }
}
