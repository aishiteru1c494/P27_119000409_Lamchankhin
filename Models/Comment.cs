using System.ComponentModel.DataAnnotations;
namespace P27_119000409_Lamchankhin.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Author { get; set; }=string.Empty;
        [Required]
        public string Content { get; set; }=string.Empty;
        public string CreatedAt { get; set; }=string.Empty;
    }
}