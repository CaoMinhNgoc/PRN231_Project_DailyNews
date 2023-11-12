using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DailyNews.BusinessObject.DTO
{
    public class CategoryDTO
    {
    }

    public class CategoryDTO_withArticles
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public List<ArticleDTO> Articles { get; set; }
    }
}
