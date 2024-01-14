using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repository
{
    public interface ILoginRepository
    {
        public List<Login> GetAllLogin();
        public Login AddLogin(Login login);
        public Login Update(int id, Login login);
        public void DeleteLogin(int id);
        public Login GetId(int id);
    }
}
