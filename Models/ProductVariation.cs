using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("product_variations")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class ProductVariation
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("products_id", TypeName = "int(11)")]
    public int ProductsId { get; set; }

    [Column("variations_id", TypeName = "int(11)")]
    public int VariationsId { get; set; }

    [Column("stock", TypeName = "int(11)")]
    public int Stock { get; set; }

    [Column("photos_hash")]
    [StringLength(16)]
    public string PhotosHash { get; set; } = null!;
}
