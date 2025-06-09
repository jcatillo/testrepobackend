using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

[Table("orders")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class Order
{
    [Key]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("reference")]
    [StringLength(255)]
    public string Reference { get; set; } = null!;

    [Column("unique_id")]
    [StringLength(128)]
    public string UniqueId { get; set; } = null!;

    [Column("students_id", TypeName = "int(11)")]
    public int? StudentsId { get; set; }

    [Column("students_guest_id", TypeName = "int(11)")]
    public int StudentsGuestId { get; set; }

    [Column("products_id", TypeName = "int(11)")]
    public int ProductsId { get; set; }

    [Column("variations_id", TypeName = "int(11)")]
    public int? VariationsId { get; set; }

    [Column("quantity", TypeName = "int(11)")]
    public int Quantity { get; set; }

    /// <summary>
    /// 1=Walk-in,2=GCash
    /// </summary>
    [Column("mode_of_payment", TypeName = "int(11)")]
    public int ModeOfPayment { get; set; }

    [Column("status", TypeName = "int(11)")]
    public int Status { get; set; }

    [Column("user_remarks")]
    [StringLength(255)]
    public string UserRemarks { get; set; } = null!;

    [Column("admin_remarks")]
    [StringLength(255)]
    public string AdminRemarks { get; set; } = null!;

    [Column("status_updated", TypeName = "datetime")]
    public DateTime? StatusUpdated { get; set; }

    [Column("edit_date", TypeName = "datetime")]
    public DateTime? EditDate { get; set; }

    [Column("date_stamp", TypeName = "datetime")]
    public DateTime DateStamp { get; set; }
}
