namespace DotnetRazor.Models;
public interface IPostRepository
{
    void AddPost(Posts posts);
    IList<Posts> ShowPost();

    Posts GetPost(string Title);
}