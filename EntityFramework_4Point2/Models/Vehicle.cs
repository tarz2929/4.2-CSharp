using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_4Point2.Models
{
    [Table("vehicle")]
    public partial class Vehicle
    {
        [Key]
        [Column("ID", TypeName = "int(10)")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Manufacturer { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Model { get; set; }
        [Column(TypeName = "int(10)")]
        public int ModelYear { get; set; }
        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Colour { get; set; }
    }
}
