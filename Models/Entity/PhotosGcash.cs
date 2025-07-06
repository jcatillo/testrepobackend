using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("photos_gcash")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class PhotosGcash
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("hash")]
    [StringLength(16)]
    public string Hash { get; set; } = null!;

    [Column("reference")]
    [StringLength(24)]
    public string Reference { get; set; } = null!;

    [Column("name", TypeName = "text")]
    public string? Name { get; set; }

    [Column("type")]
    [StringLength(16)]
    public string Type { get; set; } = null!;

    [Column("data", TypeName = "mediumblob")]
    public byte[] Data { get; set; } = null!;

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
