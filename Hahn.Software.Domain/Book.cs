using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hahn.Software.Domain;

public class Book
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [MaxLength(200)]
    [Required]
    public string Name { get; set; }
    [Required]
    [MaxLength(100)]
    public string Author { get; set; }
}
