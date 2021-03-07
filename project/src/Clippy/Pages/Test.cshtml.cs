using Clippy.Data;
using Clippy.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clippy.Pages {
    public class TestModel : PageModel {
        private ClippyContext _context;

        public TestModel(ClippyContext context) {
            _context = context;
        }

        public IList<Resource> Resources { get; set; }

        public async Task OnGetAsync() {
            Resources = await _context.GetResourcesAsync();
            Resources = Resources.ToList();
        }
    }
}
