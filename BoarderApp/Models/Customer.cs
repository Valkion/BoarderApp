using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoarderApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage ="First Name is required")]
        [DisplayName("FirstName")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public bool Active { get; set; }

        public string MacAddress { get; set; }

        public int UnitID { get; set; }   
        [ForeignKey("UnitID")]
        public virtual Unit Unit { get; set; }




        [DisplayFormat(DataFormatString = "{MM dd, yyyy}")]
        public DateTime DateCreated { get; set; }

    }
}
