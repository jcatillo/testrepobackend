using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("login_logs")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class LoginLog
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("students_id", TypeName = "int(11)")]
    public int StudentsId { get; set; }

    [Column("type", TypeName = "tinyint(4)")]
    public sbyte Type { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
