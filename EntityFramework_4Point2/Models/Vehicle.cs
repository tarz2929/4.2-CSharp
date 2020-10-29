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
        [Column("ManufacturerID", TypeName = "int(10)")]
        public int ManufacturerId { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Model { get; set; }
        [Column(TypeName = "int(10)")]
        public int ModelYear { get; set; }
        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Colour { get; set; }

        // Specifies the foreign key column itself (the one that has the value connected to the other table).
        [ForeignKey(nameof(ManufacturerId))]
        // Links to the virtual property in the parent.
        [InverseProperty("Vehicles")]
        // Represents the (singular) record for the parent.
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
