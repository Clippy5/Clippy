using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clippy.Pages.Admin {
    public class Index : PageModel {

        [ViewData]
        public string Title { get; } = "Admin";
        public void OnGet() {

        }
    }
}