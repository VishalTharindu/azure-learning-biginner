using System.ComponentModel.DataAnnotations;

namespace azure_learning_biginner.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public decimal Age { get; set; }
    }
}
