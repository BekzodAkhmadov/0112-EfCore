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

   
}