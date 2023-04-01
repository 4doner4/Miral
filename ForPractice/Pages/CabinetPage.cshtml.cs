using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;
using ForPractice.Model;

namespace ForPractice.Pages
{
    public class LoginPageModel : PageModel
    {
        private readonly BookNetDBContext _context;
        [BindProperty]
        public string Nickname { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public LoginPageModel(BookNetDBContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
             
        }

        public void OnPost()
        {
            var existUser = _context.Users.FirstOrDefault(u => u.Nickname == Nickname);

            if (existUser != null && existUser.Password == Password)
            {
                HttpContext.Session.SetString("nickname", Nickname);
                HttpContext.Session.SetString("role",
                    (_context.Roles.FirstOrDefault(r => r.Id == existUser.RoleId)).RoleName);
            }
        }
    }
}
