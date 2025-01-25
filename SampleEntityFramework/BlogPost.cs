using System;
namespace SampleEntityFramework
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedUtc { get; set; }
        public string Content { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }

        public override string ToString()
        {
            return $"{Title} ({Id})";
        }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TwitterUserName { get; set; }
        public IEnumerable<BlogPost> Posts { get; set; }
    }
}