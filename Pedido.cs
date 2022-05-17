using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MadTechAWS
{
    [Table("PEDIDOS")]
    public class Pedido
    {
        [Key]
        [Column("ID_PEDIDO")]
        public int IdPedido { get; set; }

        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("APELLIDOS")]
        public string Apellidos { get; set; }

        [Column("PAIS")]
        public string Pais { get; set; }

        [Column("DIRECCION")]
        public string Direccion { get; set; }

        [Column("DIRECCION2")]
        public string Direccion2 { get; set; }

        [Column("CIUDAD")]
        public string Ciudad { get; set; }

        [Column("LOCALIDAD")]
        public string Localidad { get; set; }

        [Column("CODIGOPOSTAL")]
        public string CodigoPostal { get; set; }

        [Column("TELEFONO")]
        public int Telefono { get; set; }

        [Column("NOTAS")]
        public string Notas { get; set; }

        [Column("FECHA_PEDIDO")]
        public DateTime FechaPedido { get; set; }

        [Column("TOTAL")]
        public int Total { get; set; }

        [Column("ESTADO")]
        public string Estado { get; set; }
    }
}
