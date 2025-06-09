using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("tatakforms_admin")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class TatakformsAdmin
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("tatakforms_students_id", TypeName = "int(11)")]
    public int TatakformsStudentsId { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
