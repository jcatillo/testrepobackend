using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("ict2024_accounts")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Ict2024Account
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("campus_id", TypeName = "tinyint(11)")]
    public sbyte CampusId { get; set; }

    [Column("username")]
    [StringLength(128)]
    public string Username { get; set; } = null!;

    [Column("password")]
    [StringLength(128)]
    public string Password { get; set; } = null!;

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
