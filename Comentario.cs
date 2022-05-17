using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MadTechAWS
{
    [Table("COMENTARIOS")]
    public class Comentario
    {
        [Key]
        [Column("ID_COMENTARIO")]
        public int IdComentario { get; set; }

        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("COMENTARIO")]
        public string Texto { get; set; }

        [Column("FECHA")]
        public DateTime Fecha { get; set; }
    }
}
