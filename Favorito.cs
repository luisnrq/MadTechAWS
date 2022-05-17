using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MadTechAWS
{
    [Table("FAVORITOS")]
    public class Favorito
    {
        [Key]
        [Column("ID_FAVORITO")]
        public int IdFavorito { get; set; }

        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }
    }
}
