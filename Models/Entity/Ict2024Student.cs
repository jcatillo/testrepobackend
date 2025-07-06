using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("ict2024_students")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Ict2024Student
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("campus_id", TypeName = "tinyint(4)")]
    public sbyte CampusId { get; set; }

    [Column("student_id")]
    [StringLength(16)]
    public string StudentId { get; set; } = null!;

    [Column("rfid")]
    [StringLength(64)]
    public string? Rfid { get; set; }

    [Column("course_id", TypeName = "tinyint(4)")]
    public sbyte CourseId { get; set; }

    [Column("tshirt_size_id", TypeName = "tinyint(4)")]
    public sbyte? TshirtSizeId { get; set; }

    [Column("year_level", TypeName = "tinyint(4)")]
    public sbyte YearLevel { get; set; }

    [Column("first_name")]
    [StringLength(128)]
    public string FirstName { get; set; } = null!;

    [Column("last_name")]
    [StringLength(128)]
    public string LastName { get; set; } = null!;

    [Column("email")]
    [StringLength(256)]
    public string Email { get; set; } = null!;

    [Column("discount_code")]
    [StringLength(16)]
    public string DiscountCode { get; set; } = null!;

    [Column("attendance", TypeName = "datetime")]
    public DateTime? Attendance { get; set; }

    [Column("payment_confirmed", TypeName = "datetime")]
    public DateTime? PaymentConfirmed { get; set; }

    [Column("tshirt_claimed", TypeName = "datetime")]
    public DateTime? TshirtClaimed { get; set; }

    [Column("snack_claimed", TypeName = "tinyint(4)")]
    public sbyte SnackClaimed { get; set; }

    [Column("kits_claimed", TypeName = "tinyint(4)")]
    public sbyte KitsClaimed { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
