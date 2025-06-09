using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("products")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class Product
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("slug")]
    [StringLength(32)]
    public string Slug { get; set; } = null!;

    [Column("photos_hash")]
    [StringLength(16)]
    public string? PhotosHash { get; set; }

    [Column("description", TypeName = "text")]
    public string Description { get; set; } = null!;

    [Column("likes", TypeName = "int(11)")]
    public int Likes { get; set; }

    [Column("stock", TypeName = "int(11)")]
    public int Stock { get; set; }

    [Column("price", TypeName = "int(11)")]
    public int Price { get; set; }

    [Column("max_quantity", TypeName = "int(11)")]
    public int MaxQuantity { get; set; }

    [Column("is_available", TypeName = "tinyint(4)")]
    public sbyte IsAvailable { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
