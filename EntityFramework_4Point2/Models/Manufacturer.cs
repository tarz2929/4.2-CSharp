using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_4Point2.Models
{
    // Data Annotations provide EF Core some information about the tables and columns in order to make an accurate model.

    // Defines the name of the table.
    [Table("manufacturer")]
    public partial class Manufacturer
    {
        // Required because we have the virtual collection (initialized so it isn't null).
        public Manufacturer()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        // Specifies a PRIMARY KEY
        [Key]
        // Specifies a column name and data type. If the column name is not provided in the [Column], it will infer that it is identical to the property name.
        [Column("ID", TypeName = "int(10)")]
        public int Id { get; set; }

        // Specifies NOT NULL on nullable C# types (like strings). 
        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Name { get; set; }

        // Draws a link to a property in another model (used for foreign keys).
        [InverseProperty("Manufacturer")]
        // Represents the list of associated records through the foreign key (the records with this record as their parent). This should be plural.
        // When we access this virtual property, it does a JOIN behind the scenes to access the associated records.
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
