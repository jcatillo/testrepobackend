using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("tatakforms_reset_tokens")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class TatakformsResetToken
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("tatakforms_students_id", TypeName = "int(11)")]
    public int TatakformsStudentsId { get; set; }

    [Column("token")]
    [StringLength(24)]
    public string Token { get; set; } = null!;

    [Column("is_used", TypeName = "tinyint(4)")]
    public sbyte IsUsed { get; set; }

    [Column("reset_date_stamp", TypeName = "datetime")]
    public DateTime? ResetDateStamp { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
