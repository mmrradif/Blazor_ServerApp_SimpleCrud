using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor.Database
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;



        [Required(ErrorMessage ="Name is required")]
        [StringLength(50)]
        public string Name { get; set; } = default!;



        [Required(ErrorMessage = "Type is required")]
        [StringLength(50)]
        public string Type { get; set; } = default!;
    }
}
