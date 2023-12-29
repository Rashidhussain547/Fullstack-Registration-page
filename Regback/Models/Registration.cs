using System.ComponentModel.DataAnnotations;

namespace Regback.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }
}
