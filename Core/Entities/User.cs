using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
