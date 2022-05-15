using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Doceria.Models
{
    [Table("TB_TORTA")]
    public class Torta
    {
        [HiddenInput]
        public int TortaId { get; set; }
        [Column("NM_TORTA"), Required, MaxLength(50)]
        public string Nome { get; set; }
        [Column("DS_TORTA"), Required, MaxLength(250)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Column("VL_PRECO"), Required]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        [Column("DT_CADASTRO"), Required]
        [Display(Name ="Data do cadastro"), DataType(DataType.Date)]
        public DateTime Data { get; set; }
        [Column("NM_TIPO"), Required]
        [Display(Name = "Tipo de Torta")]
        public TipoTorta Tipo { get; set; }
        [Column("BL_VEGANA"), Required]
        [Display(Name = "Vegana?")]
        public bool IsVegana { get; set; }
    }

    public enum TipoTorta
    {
        Especial, Tradicional, Sorvete, Vintage
    }

}
