using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using rpc_razor_auth.Data;
using rpc_razor_auth.Models;

namespace rpc_razor_auth.Pages.AuthRPC
{
    public class SignInModel : PageModel
    {
        private readonly UsersDbContext _db;
        public SignInModel(UsersDbContext db)
        {
            _db = db;
        }

        
        [BindProperty]
        public new User User { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string pw, string us)
        {
            User = _db.User.Find(us);
            if (User != null)
            {
                if (!User.Password.Equals(pw))
                {
                    return Page();
                }
                await _db.SaveChangesAsync();
                return RedirectToPage("UserTableView");
            }
            return Page();
        }

    }
}
