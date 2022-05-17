using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MadTechAWS
{
    [Table("USUARIOS")]
    public class Usuario
    {
        [Key]
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("USUARIO")]
        public string NombreUsuario { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("SALT")]
        public string Salt { get; set; }

        //Los tipos blob, clob o varbinary son convertidos en los context automaticamente a byte[]
        [Column("PASS")]
        public byte[] Password { get; set; }

        [Column("TIPO")]
        public string TipoUsario { get; set; }
    }
}
