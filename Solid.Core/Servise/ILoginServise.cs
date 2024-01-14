using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servise
{
    public interface ILoginServise
    {
        public List<Login> GetLogins();
        public Login AddLogins(Login login);
        public void DeleteLogins(int id);
        public Login Update(int id, Login login);
        public Login GetId(int id);
    }
}
