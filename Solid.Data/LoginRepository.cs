using Solid.Core;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return dataContext.login.ToList();
        }
        public Login AddLogin(Login city)
        {
            dataContext.login.Add(city);
            dataContext.SaveChanges();
            return city;
            
        }
        public Login GetId(int id)
        {
            var city = dataContext.login.Find(id);
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
            var login=dataContext.login.Find(id);
            dataContext.login.Remove(login);
            dataContext.SaveChanges();
        }

    }
}
