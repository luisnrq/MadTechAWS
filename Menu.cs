using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MadTechAWS
{
    [Table("CATEGORIAS")]
    public class Menu
    {
        [Key]
        [Column("NOMBRE_CATEGORIA")]
        public string Nombre { get; set; }

        [Column("IMAGEN")]
        public string Imagen { get; set; }
    }
}
