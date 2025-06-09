using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("edit_logs")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class EditLog
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("admin_id", TypeName = "int(11)")]
    public int AdminId { get; set; }

    [Column("method")]
    [StringLength(12)]
    public string Method { get; set; } = null!;

    [Column("table")]
    [StringLength(64)]
    public string Table { get; set; } = null!;

    [Column("before")]
    [StringLength(1024)]
    public string Before { get; set; } = null!;

    [Column("after")]
    [StringLength(1024)]
    public string After { get; set; } = null!;

    [Column("ip_address")]
    [StringLength(32)]
    public string IpAddress { get; set; } = null!;

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
