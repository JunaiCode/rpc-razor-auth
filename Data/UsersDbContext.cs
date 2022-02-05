using System;
using Microsoft.EntityFrameworkCore;
using rpc_razor_auth.Models;

namespace rpc_razor_auth.Data
{
    public class UsersDbContext: DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options): base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}
