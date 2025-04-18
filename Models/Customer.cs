using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace RepairAndConstruction.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Mandatory")]
        [Display(Name = "Name and Surname")]
        public string FullName { get; set; }

        [ValidateNever]
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        

    }

}
