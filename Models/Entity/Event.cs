using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("events")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class Event
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("photos_hash")]
    [StringLength(16)]
    public string? PhotosHash { get; set; }

    [Column("title")]
    [StringLength(255)]
    public string Title { get; set; } = null!;

    [Column("description", TypeName = "text")]
    public string? Description { get; set; }

    [Column("venue")]
    [StringLength(255)]
    public string Venue { get; set; } = null!;

    [Column("date")]
    public DateOnly Date { get; set; }

    [Column("start_time", TypeName = "time")]
    public TimeOnly StartTime { get; set; }

    [Column("end_time", TypeName = "time")]
    public TimeOnly EndTime { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
