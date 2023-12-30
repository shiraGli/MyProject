using Solid.Core;
using Solid.Core.Repository;
using Solid.Core.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Servise
{
    public class CityServise: ICityServise
    {
        private readonly ICityRepository _cityRepository;
        public CityServise(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public List<City> GetCities()
        {
            return _cityRepository.GetAllCity();
        }
        public City AddCity(City city)
        {
            return _cityRepository.AddCity(city);
        }
        public City Update(int id, City city)
        {
            return _cityRepository.Update(id, city);
           
        }
        public void DeleteCity(int id)
        {
            _cityRepository.DeleteCity(id);
        }
        public City GetId(int id)
        {
            return _cityRepository.GetId(id);
        }
    }
}
