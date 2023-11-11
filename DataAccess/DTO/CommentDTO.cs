namespace DailyNews.DataAccess.DTO
{
    public class CommentCreateRequestDTO
    {
        public string? CommentContent { get; set; }
        public DateTime CommentTime { get; set; }
        public int? Rating { get; set; }
        public int ArticleId { get; set; }
        public string MemberId { get; set; }
    }

    public class CommentUpdateRequestDTO
    {
        public string? CommentContent { get; set; }
        public int? Rating { get; set; }
    }
}
