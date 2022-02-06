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
    public class SignUpModel : PageModel
    {
        private readonly UsersDbContext _db;
        public SignUpModel(UsersDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public User User { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string ValidationPassword)
        {
            if (!ModelState.IsValid || ValidationPassword != User.Password)
            {
                return Page();
            }
            _db.Add(User);
            await _db.SaveChangesAsync();
            return RedirectToPage("SignIn");
        }
    }
}
