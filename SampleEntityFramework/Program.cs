using System;
using Microsoft.EntityFrameworkCore;
using SampleEntityFramework.Migrations;
namespace SampleEntityFramework
{
    public class Program
    {
        static void Main(string[] args)
        {
            var db = new AppDbContext();
            GetPosts(db);
            AddPost(db);
            //UpdatePost(db);
            //DeletePost(db);
        }

        private static void GetPosts(AppDbContext db)
        {
            var posts = db.Posts.AsNoTracking().Where(p => p.Id < 10);
            //Console.WriteLine(posts.ToQueryString());
            if (!posts.Any())
            {
                Console.WriteLine("** No blog posts foubd**");
                return;
            }
            foreach (var p in posts)
            {
                Console.WriteLine(p.ToString());
            }
        }

        private static void AddPost(AppDbContext db)
        {
            var newPost = new BlogPost
            {
                Title = "My First Post",
                PublishedUtc = DateTime.UtcNow,
                Content = "This is my first post and I am very proud of it"
            };

            db.Posts.Add(newPost);
            db.SaveChanges();
        }

        private static void UpdatePost(AppDbContext db)
        {
            var post = db.Posts.First(p => p.Id == 1);
            post.Title = "I hacked your post!";
            db.SaveChanges();
            GetPosts(db);
        }

        private static void DeletePost(AppDbContext db)
        {
            db.Posts.Remove(db.Posts.First(p => p.Id == 1));
            db.SaveChanges();
            GetPosts(db);
        }
    }
}