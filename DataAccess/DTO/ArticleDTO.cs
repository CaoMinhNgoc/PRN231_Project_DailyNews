namespace DailyNews.DataAccess.DTO
{
    public class ArticleRequestDTO
    {
        public string Title { get; set; }
        public string? ShortDescription { get; set; }
        public string Content { get; set; }
        public bool Published { get; set; }
        public int CategoryId { get; set; }
    }
}
