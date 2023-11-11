using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject.Models
{
    public class Comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }

        public string? CommentContent { get; set; }
        public DateTime CommentTime { get; set; }

        [Range(0, 5)]
        public int? Rating { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
