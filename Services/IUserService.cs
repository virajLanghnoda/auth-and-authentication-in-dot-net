using final_authorization_and_authorization.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_authorization_and_authorization.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        List<User> GetAllUsers();
    }
}
