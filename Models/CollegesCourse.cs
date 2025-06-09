using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("colleges_courses")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class CollegesCourse
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("college_id", TypeName = "int(11)")]
    public int CollegeId { get; set; }

    [Column("acronym")]
    [StringLength(8)]
    public string Acronym { get; set; } = null!;

    [Column("name")]
    [StringLength(128)]
    public string Name { get; set; } = null!;
}
