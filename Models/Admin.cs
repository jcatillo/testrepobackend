using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("admin")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class Admin
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("students_id")]
    [StringLength(16)]
    public string StudentsId { get; set; } = null!;

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
