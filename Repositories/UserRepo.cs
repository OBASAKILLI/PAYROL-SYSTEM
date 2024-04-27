using Microsoft.EntityFrameworkCore;
using PAYROL_SYSTEM.Context;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Repositories
{
    public class UserRepo : GenericRepo<Users>, IUserRepo
    {
        public UserRepo(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public Users Login(string Username, string Password)
        {
            return _appDbContext.Users.FirstOrDefault(x => x.strUsername == Username && x.strPassword == Password);

        }
    }
}
