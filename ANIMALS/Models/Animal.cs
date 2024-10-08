using System.ComponentModel.DataAnnotations;

namespace ANIMALS.Models
{
    public class Animal
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the name of the animal")]
        [StringLength(30, ErrorMessage = "Name of the animal cannot be longer than 30 characters")]
        public string Name { get; set; }

        [Required]
        public string LifeSpan { get; set; }
        public decimal Price { get; set; }
        [Required]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Length cannot be more than 200 characters")]
        public string Description { get; set; }
    }
}
