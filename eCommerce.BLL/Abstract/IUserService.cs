using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BLL.Abstract
{
    public interface IUserService : IServiceBase<User>
    {
        User Login(string username, string password);
    }
}
