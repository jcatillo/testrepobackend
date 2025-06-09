using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("tatakforms")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Tatakform
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("slug")]
    [StringLength(64)]
    public string Slug { get; set; } = null!;

    [Column("name")]
    [StringLength(128)]
    public string Name { get; set; } = null!;

    [Column("from_date")]
    public DateOnly FromDate { get; set; }

    [Column("to_date")]
    public DateOnly ToDate { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
