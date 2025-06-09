using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("tutorials")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class Tutorial
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("student_id")]
    [StringLength(12)]
    public string StudentId { get; set; } = null!;

    [Column("language")]
    [StringLength(50)]
    public string Language { get; set; } = null!;

    [Column("schedule", TypeName = "datetime")]
    public DateTime Schedule { get; set; }

    [Column("status", TypeName = "enum('Pending','Approved','Rejected','Done')")]
    public string Status { get; set; } = null!;

    [Column("status_date_stamp", TypeName = "datetime")]
    public DateTime StatusDateStamp { get; set; }

    [Column("remarks")]
    [StringLength(255)]
    public string? Remarks { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
