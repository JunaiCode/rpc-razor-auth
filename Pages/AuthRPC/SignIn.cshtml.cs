using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using rpc_razor_auth.Models;

namespace rpc_razor_auth.Pages.AuthRPC
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        public void OnGet()
        {
        }
    }
}
