using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("ict2024_campus")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Ict2024Campus
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("campus")]
    [StringLength(16)]
    public string Campus { get; set; } = null!;

    [Column("campus_name")]
    [StringLength(32)]
    public string CampusName { get; set; } = null!;
}
