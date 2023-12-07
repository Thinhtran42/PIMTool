using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels.EmployeeViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public byte[]? Version { get; set; }
        [Required]
        [MaxLength(3)]
        public string Visa { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}