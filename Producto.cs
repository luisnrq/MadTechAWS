using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MadTechAWS
{
    [Table("PRODUCTOS")]
    public class Producto
    {
        [Key]
        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }

        [Column("NOMBRE_CATEGORIA")]
        public string NombreCategoria { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("DESCRIPCION_CORTA")]
        public string DescripcionCorta { get; set; }

        [Column("DESCRIPCION_LARGA")]
        public string DescripcionLarga { get; set; }

        [Column("PRECIO")]
        public int Precio { get; set; }

        [Column("STOCK")]
        public int Stock { get; set; }

        [Column("IMAGEN1")]
        public string Imagen1 { get; set; }

        [Column("IMAGEN2")]
        public string Imagen2 { get; set; }

        [Column("IMAGEN3")]
        public string Imagen3 { get; set; }

        [Column("IMAGEN4")]
        public string Imagen4 { get; set; }

        [Column("video")]
        public string Video { get; set; }
    }
}
