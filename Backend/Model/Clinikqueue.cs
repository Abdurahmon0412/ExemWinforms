using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Backend;

[Table("clinikqueue")]
public partial class Clinikqueue
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("dataofcreate")]
    public DateOnly Dataofcreate { get; set; }

    [Column("iscomplate")]
    public bool Iscomplate { get; set; }

    [Column("person_id")]
    public int PersonId { get; set; }

    [Column("doctor_id")]
    public int DoctorId { get; set; }

    [ForeignKey("DoctorId")]
    [InverseProperty("Clinikqueues")]
    public virtual Doctor Doctor { get; set; } = null!;

    [ForeignKey("PersonId")]
    [InverseProperty("Clinikqueues")]
    public virtual Person Person { get; set; } = null!;
}
