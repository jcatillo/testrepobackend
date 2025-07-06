using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("students_guest")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class StudentsGuest
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("student_id")]
    [StringLength(12)]
    public string StudentId { get; set; } = null!;

    [Column("first_name")]
    [StringLength(32)]
    public string FirstName { get; set; } = null!;

    [Column("last_name")]
    [StringLength(32)]
    public string LastName { get; set; } = null!;

    [Column("email_address")]
    [StringLength(128)]
    public string EmailAddress { get; set; } = null!;

    [Column("course", TypeName = "tinyint(4)")]
    public sbyte Course { get; set; }

    [Column("year_level", TypeName = "tinyint(4)")]
    public sbyte YearLevel { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
