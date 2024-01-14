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
    public class LoginServise: ILoginServise
    {
        private readonly ILoginRepository _loginRepository;
        public LoginServise(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public List<Login> GetLogins()
        {
            return _loginRepository.GetAllLogin();
        }
        public Login AddLogins(Login login)
        {
            return _loginRepository.AddLogin(login);
        }
        public Login Update(int id, Login login)
        {
            return _loginRepository.Update(id, login);
           
        }
        public void DeleteLogins(int id)
        {
            _loginRepository.DeleteLogin(id);
        }
        public Login GetId(int id)
        {
            return _loginRepository.GetId(id);
        }
    }
}
