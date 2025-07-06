using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Request;

namespace backend.Models;

[Table("students")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class Student
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("student_id")]
    [StringLength(32)]
    public string StudentId { get; set; } = null!;

    [Column("last_name")]
    [StringLength(64)]
    public string LastName { get; set; } = null!;

    [Column("first_name")]
    [StringLength(64)]
    public string FirstName { get; set; } = null!;

    [Column("year_level", TypeName = "int(11)")]
    public int YearLevel { get; set; }

    [Column("email_address")]
    [StringLength(100)]
    public string EmailAddress { get; set; } = null!;

    [Column("password")]
    [StringLength(100)]
    public string Password { get; set; } = null!;

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }


}
