using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rpc_razor_auth.Data;
using rpc_razor_auth.Models;
using rpc_razor_auth.Pages;

namespace rpc_razor_auth.Pages.AuthRPC
{
    public class UserTableViewModel : PageModel
    {
        private readonly UsersDbContext _db;

        public UserTableViewModel(UsersDbContext db)
        {
            _db = db;
        }

        public IEnumerable<User> Users { get; set; }
        public new User User { get; set; }
        public async Task OnGet()
        {
            Users = await _db.User.ToListAsync();
        }
    }
}
