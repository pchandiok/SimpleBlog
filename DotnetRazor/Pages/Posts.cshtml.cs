using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotnetRazor.Models;

namespace DotnetRazor
{
    public class PostsModel : PageModel
    {
        private readonly IPostRepository _repo;

        public PostsModel(IPostRepository repo)
        {
            _repo = repo;
        }

        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }

        public Posts post { get; set; }
        public void OnGet()
        {
            post = _repo.GetPost(Title);
        }
    }
}
