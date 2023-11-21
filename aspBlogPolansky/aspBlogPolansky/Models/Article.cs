using System.ComponentModel.DataAnnotations;

namespace aspBlogPolansky.Models
{
    public class Article
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Vyplňte obsah")]
        public string Content { get; set; } = "";

        [Required(ErrorMessage = "Vyplňte titulek")]
        [StringLength(100, ErrorMessage = "Titulek je příliš dlouhý")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Vyplňte popisek")]
        public string Description { get; set; } = "";
    }
}
