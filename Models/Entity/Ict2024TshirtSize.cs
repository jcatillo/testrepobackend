using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("ict2024_tshirt_sizes")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Ict2024TshirtSize
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("code")]
    [StringLength(8)]
    public string Code { get; set; } = null!;

    [Column("name")]
    [StringLength(32)]
    public string Name { get; set; } = null!;
}
