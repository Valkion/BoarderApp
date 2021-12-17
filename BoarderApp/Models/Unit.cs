using System;
using System.ComponentModel.DataAnnotations;

namespace BoarderApp.Models
{
    public class Unit
    {
        [Key]
        public int UnitID { get; set; }
        public string UnitName { get; set; }

    }
}