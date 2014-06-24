using System;
using System.ComponentModel.DataAnnotations;

namespace Muse.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string Name { get; set; }

        [Required, MaxLength(250)]
        public string Username { get; set; }

        [Required, MaxLength(250)]
        public string Password { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [MaxLength(250)]
        public string Address { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}