using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotnetRazor.Models;

namespace DotnetRazor.Pages
{
    public class IndexModel : PageModel
    {

        private readonly IPostRepository _repo;

        public IndexModel(IPostRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public string homeStartingContent { get; set; } = "Lacus vel facilisis volutpat est velit egestas dui id ornare. Semper auctor neque vitae tempus quam. Sit amet cursus sit amet dictum sit amet justo. Viverra tellus in hac habitasse. Imperdiet proin fermentum leo vel orci porta. Donec ultrices tincidunt arcu non sodales neque sodales ut. Mattis molestie a iaculis at erat pellentesque adipiscing. Magnis dis parturient montes nascetur ridiculus mus mauris vitae ultricies. Adipiscing elit ut aliquam purus sit amet luctus venenatis lectus. Ultrices vitae auctor eu augue ut lectus arcu bibendum at. Odio euismod lacinia at quis risus sed vulputate odio ut. Cursus mattis molestie a iaculis at erat pellentesque adipiscing.";
        
        public IList<Posts> posts { get; set; }
        
        public IActionResult OnGet()
        {
            posts = _repo.ShowPost();
            return Page();
        }
    }
}
