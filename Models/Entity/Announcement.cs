using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("announcements")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class Announcement
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("admin_student_id")]
    [StringLength(12)]
    public string AdminStudentId { get; set; } = null!;

    [Column("title")]
    [StringLength(128)]
    public string Title { get; set; } = null!;

    [Column("content")]
    [StringLength(2048)]
    public string Content { get; set; } = null!;

    [Column("photos_hash")]
    [StringLength(16)]
    public string? PhotosHash { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
