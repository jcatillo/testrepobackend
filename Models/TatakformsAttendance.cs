using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("tatakforms_attendance")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class TatakformsAttendance
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("event_id", TypeName = "int(11)")]
    public int EventId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int StudentId { get; set; }

    [Column("day1_am", TypeName = "datetime")]
    public DateTime? Day1Am { get; set; }

    [Column("day1_pm", TypeName = "datetime")]
    public DateTime? Day1Pm { get; set; }

    [Column("day2_am", TypeName = "datetime")]
    public DateTime? Day2Am { get; set; }

    [Column("day2_pm", TypeName = "datetime")]
    public DateTime? Day2Pm { get; set; }

    [Column("day3_am", TypeName = "datetime")]
    public DateTime? Day3Am { get; set; }

    [Column("day3_pm", TypeName = "datetime")]
    public DateTime? Day3Pm { get; set; }
}
