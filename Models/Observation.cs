using System.ComponentModel.DataAnnotations;

namespace Dentiste.Models
{
    public class Observation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Note { get; set; }
    }
}
