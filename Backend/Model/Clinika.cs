using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Backend;

[Table("clinika")]
public partial class Clinika
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("fullname")]
    [StringLength(50)]
    public string Fullname { get; set; } = null!;

    [Column("address")]
    [StringLength(100)]
    public string? Address { get; set; }

    [Column("phone_number")]
    [StringLength(14)]
    public string? PhoneNumber { get; set; }

    [InverseProperty("Clinika")]
    public virtual ICollection<Medservice> Medservices { get; set; } = new List<Medservice>();

    [InverseProperty("Clinika")]
    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
