namespace Quete1.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Article(int id, string title, string content)
        {
            Id = id;
            Title = title;
            Content = content;
        }
    }
}
