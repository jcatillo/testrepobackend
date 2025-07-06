using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("Roginand")]
public partial class Roginand
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
