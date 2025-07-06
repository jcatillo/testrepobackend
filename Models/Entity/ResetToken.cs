using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("reset_tokens")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class ResetToken
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("students_id", TypeName = "int(11)")]
    public int StudentsId { get; set; }

    [Column("token")]
    [StringLength(24)]
    public string Token { get; set; } = null!;

    [Column("is_used")]
    public bool IsUsed { get; set; }

    [Column("reset_date_stamp", TypeName = "datetime")]
    public DateTime? ResetDateStamp { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
