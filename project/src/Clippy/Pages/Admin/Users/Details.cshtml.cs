using Clippy.Data;
using Clippy.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Clippy.Pages.Admin.Users
{
    public class DetailsModel : PageModel
    {
        private ClippyContext _context;

        public DetailsModel(ClippyContext context) {
            _context = context;
        }

        [BindProperty]
        public User UserEntity { get; set; }

        public async Task<IActionResult> OnGetAsync(int id) {
            UserEntity = await _context.GetUserAsync(id);
            if (UserEntity == null)
                return RedirectToPage("./Index");

            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var user = await _context.GetUserAsync(id);

            if (user == null)
                return RedirectToPage("./Index");

            _context.Remove(user);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
