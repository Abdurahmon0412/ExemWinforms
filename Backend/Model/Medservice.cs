using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Backend;

[Table("medservice")]
public partial class Medservice
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("medservice_name")]
    [StringLength(50)]
    public string MedserviceName { get; set; } = null!;

    [Column("service_price")]
    public decimal ServicePrice { get; set; }

    [Column("clinika_id")]
    public int ClinikaId { get; set; }

    [ForeignKey("ClinikaId")]
    [InverseProperty("Medservices")]
    public virtual Clinika Clinika { get; set; } = null!;

    [InverseProperty("Medservice")]
    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    [InverseProperty("Medservice")]
    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
