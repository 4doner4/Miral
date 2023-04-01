using ForPractice.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;

namespace ForPractice.Pages
{
    public class RegistrationPageModel : PageModel
    {
        private readonly BookNetDBContext _context;
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Nickname { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string Reppasswd { get; set; }

        public RegistrationPageModel(BookNetDBContext db)
        {
            _context = db;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            var existUser = _context.Users.FirstOrDefault(u => u.Nickname == Nickname);

            if (existUser == null && Password == Reppasswd && Name != null && Nickname != null && Password != null)
            {
                User user = new User();
                user.Name = Name;
                user.Nickname = Nickname;
                user.Password = Password;
                user.RoleId = (_context.Roles.FirstOrDefault(r => r.RoleName == "user")).Id;
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }

            return RedirectToPage("Error");
        }
    }
}
