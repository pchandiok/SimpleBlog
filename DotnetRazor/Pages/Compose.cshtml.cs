using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotnetRazor.Models;

namespace DotnetRazor.Pages
{
    public class ComposeModel : PageModel
    {
        private readonly IPostRepository _repo;

        public ComposeModel(IPostRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public Posts Post { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _repo.AddPost(Post);
            return RedirectToPage("/Index");
        }
    }
}
