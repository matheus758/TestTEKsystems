using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        [DataType(DataType.Password)]
        [MaxLength(100)]
        [MinLength(3)]
        public required string Password { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
    }
}
