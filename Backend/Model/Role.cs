using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Backend;

[Table("role")]
public partial class Role
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("role_name")]
    [StringLength(10)]
    public string RoleName { get; set; } = null!;

    [InverseProperty("Role")]
    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
