using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Backend;

[Table("doctor")]
public partial class Doctor
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("doctor_name")]
    [StringLength(25)]
    public string DoctorName { get; set; } = null!;

    [Column("start_time")]
    public DateOnly StartTime { get; set; }

    [Column("end_time")]
    public DateOnly EndTime { get; set; }

    [Column("floor_place")]
    public int FloorPlace { get; set; }

    [Column("room_place")]
    public int RoomPlace { get; set; }

    [Column("experience")]
    public int Experience { get; set; }

    [Column("person_id")]
    public int PersonId { get; set; }

    [Column("medservice_id")]
    public int MedserviceId { get; set; }

    [InverseProperty("Doctor")]
    public virtual ICollection<Clinikqueue> Clinikqueues { get; set; } = new List<Clinikqueue>();

    [ForeignKey("MedserviceId")]
    [InverseProperty("Doctors")]
    public virtual Medservice Medservice { get; set; } = null!;

    [ForeignKey("PersonId")]
    [InverseProperty("Doctors")]
    public virtual Person Person { get; set; } = null!;
}
