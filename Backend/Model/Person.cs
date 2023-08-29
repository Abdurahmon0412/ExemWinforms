using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Backend.Model;
using Microsoft.EntityFrameworkCore;

namespace Backend;

[Table("person")]
public partial class Person
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("login")]
    [StringLength(25)]
    public string Login { get; set; } = null!;

    [Column("password")]
    [StringLength(25)]
    public string Password { get; set; } = null!;

    [Column("lastname")]
    [StringLength(25)]
    public string Lastname { get; set; } = null!;

    [Column("firstname")]
    [StringLength(25)]
    public string Firstname { get; set; } = null!;

    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("medservice_id")]
    public int? MedserviceId { get; set; }

    [Column("clinika_id")]
    public int ClinikaId { get; set; }

    [InverseProperty("Person")]
    public virtual ICollection<Analyser> Analysers { get; set; } = new List<Analyser>();

    [ForeignKey("ClinikaId")]
    [InverseProperty("People")]
    public virtual Clinika Clinika { get; set; } = null!;

    [InverseProperty("Person")]
    public virtual ICollection<Clinikqueue> Clinikqueues { get; set; } = new List<Clinikqueue>();

    [InverseProperty("Person")]
    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    [ForeignKey("MedserviceId")]
    [InverseProperty("People")]
    public virtual Medservice? Medservice { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("People")]
    public virtual Role Role { get; set; } = null!;
}
