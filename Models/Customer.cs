using System.ComponentModel.DataAnnotations;

namespace CrudPractice.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }
    }
}