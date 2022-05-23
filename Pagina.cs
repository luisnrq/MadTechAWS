using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MadTechAWS
{
    [Table("PAGINAS")]
    public class Pagina
    {
        [Column("ID_PAGINA")]
        public int IdPagina { get; set; }

        [Column("TITULO ")]
        public string Titulo { get; set; }

        [Column("CONTENIDO")]
        public string Contenido { get; set; }
    }
}
