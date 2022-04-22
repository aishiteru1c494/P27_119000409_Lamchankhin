

using System.ComponentModel.DataAnnotations;
namespace P27_119000409_Lamchankhin.Models
{
    public class News
    {
        public int Id { get; set; }
        [StringLength(200,MinimumLength =50)]
        [Required]
        public string Title { get; set; }=string.Empty;
        [Required]
        public string ImageUrl { get; set; }=string.Empty;
        [StringLength(500,MinimumLength =100)]
        [Required]
        public string Content { get; set; }=string.Empty;
        [Required]
        public string Author { get; set; }=string.Empty;
    }
}