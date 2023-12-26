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

    }
}
