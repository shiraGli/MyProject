using Solid.Core;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    
    public class CityRepository: ICityRepository
    {
        private readonly DataContext dataContext;
            public CityRepository(DataContext context)
        {
            dataContext = context;
        }
        public List<City> GetAllCity()
        {
            return dataContext.city.ToList();
        }
        public City AddCity(City city)
        {
            dataContext.city.Add(city);
            dataContext.SaveChanges();
            return city;
            
        }
        public City GetId(int id)
        {
            var city = dataContext.city.Find(id);
            return city;
        }
        public City Update(int id,City city)
        {
           var cityChange=GetId(id);
            cityChange.Name = city.Name;
            cityChange.Count= city.Count;
            dataContext.SaveChanges();
            return cityChange;
        }
        public void DeleteCity(int id)
        {
            var city=dataContext.city.Find(id);
            dataContext.city.Remove(city);
            dataContext.SaveChanges();
        }

    }
}
