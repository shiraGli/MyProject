using Microsoft.EntityFrameworkCore;
using Solid.Core;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    
    public class LoginRepository: ILoginRepository
    {
        private readonly DataContext dataContext;
            public LoginRepository(DataContext context)
        {
            dataContext = context;
        }
        public List<Login> GetAllLogin()
        {
            return dataContext._login.Include(u=>u.Course).Include(y=>y.Student).ToList();
        }
        public Login AddLogin(Login city)
        {
            dataContext._login.Add(city);
            dataContext.SaveChanges();
            return city;
            
        }
        public Login GetId(int id)
        {
            var city = dataContext._login.Find(id);
            return city;
        }
        public Login Update(int id,Login login)
        {
           var loginChange=GetId(id);
            loginChange.Date = login.Date;
            dataContext.SaveChanges();
            return loginChange;
        }
        public void DeleteLogin(int id)
        {
            var login=dataContext._login.Find(id);
            dataContext._login.Remove(login);
            dataContext.SaveChanges();
        }

    }
}
