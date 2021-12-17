using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoarderApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }

        public string MacAddress { get; set; }

        public int Unit { get; set; }   
        [ForeignKey("UnitID")]
        public virtual Unit UnitName { get; set; }




        [DisplayFormat(DataFormatString = "{MM dd, yyyy}")]
        public DateTime DateCreated { get; set; }

    }
}
