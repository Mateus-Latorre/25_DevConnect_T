using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_curtida")]
[Index("IdUsuario", "IdPublicacao", Name = "UQ__tb_curti__F0961F6F50BC1641", IsUnique = true)]
public partial class TbCurtida
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_usuario")]
    public int? IdUsuario { get; set; }

    [Column("id_publicacao")]
    public int? IdPublicacao { get; set; }

    [ForeignKey("IdPublicacao")]
    [InverseProperty("TbCurtida")]
    public virtual TbPublicacao? IdPublicacaoNavigation { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbCurtida")]
    public virtual TbUsuario? IdUsuarioNavigation { get; set; }
}
