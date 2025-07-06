using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("Atillo")]
public partial class Atillo
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("giatay")]
    public string Giatay { get; set; } = null!;
}
