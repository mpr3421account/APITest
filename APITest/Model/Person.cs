using System.ComponentModel.DataAnnotations;

namespace APITest.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Adress { get; set; }


    }
}
