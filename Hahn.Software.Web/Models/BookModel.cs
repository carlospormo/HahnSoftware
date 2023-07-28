using System.ComponentModel.DataAnnotations;

namespace Hahn.Software.Web.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Author { get; set; }
    }
}
