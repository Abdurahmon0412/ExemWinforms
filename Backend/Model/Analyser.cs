using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Backend;

[Table("analyser")]
public partial class Analyser
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("person_id")]
    public int PersonId { get; set; }

    [Column("details")]
    [StringLength(200)]
    public string Details { get; set; } = null!;

    [ForeignKey("PersonId")]
    [InverseProperty("Analysers")]
    public virtual Person Person { get; set; } = null!;
}
