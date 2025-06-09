using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("env")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class Env
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("key")]
    [StringLength(255)]
    public string Key { get; set; } = null!;

    [Column("value", TypeName = "text")]
    public string Value { get; set; } = null!;

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
