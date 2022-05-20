using System.Collections.Generic;

namespace DotnetRazor.Models;
public class PostRepository : IPostRepository
{
    public static IList<Posts> posts { get; set; } = new List<Posts>();
    public void AddPost(Posts post)
    {
        posts.Add(post);
    }

    public IList<Posts> ShowPost()
    {
        // Console.WriteLine("I'm in Show Post");
        // foreach(var post in posts)
        // {
        //     Console.WriteLine($"Show Post: {post.Body}");
        // }
        return posts;
    }

    public Posts GetPost(string Title)
    {
        var post = posts.FirstOrDefault( p => p.Title == Title);
        return post;
    }
}