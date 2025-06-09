using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("ict2024_discount_codes")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Ict2024DiscountCode
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("campus_id", TypeName = "int(11)")]
    public int CampusId { get; set; }

    [Column("code")]
    [StringLength(16)]
    public string Code { get; set; } = null!;

    [Column("price", TypeName = "int(11)")]
    public int Price { get; set; }

    [Column("expiration", TypeName = "datetime")]
    public DateTime Expiration { get; set; }
}
