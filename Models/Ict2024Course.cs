using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("ict2024_courses")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Ict2024Course
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("course")]
    [StringLength(2)]
    public string Course { get; set; } = null!;

    [Column("course_name")]
    [StringLength(16)]
    public string CourseName { get; set; } = null!;
}
