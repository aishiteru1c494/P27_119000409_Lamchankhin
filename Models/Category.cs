using System.ComponentModel.DataAnnotations;
namespace P27_119000409_Lamchankhin.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Required]
        public string Name { get; set; }=string.Empty;
    }
}