using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MadTechAWS
{
    [Table("LINEAS_PEDIDO")]
    public class LineaPedido
    {
        [Key]
        [Column("ID_LINEA")]
        public int IdLinea { get; set; }

        [Column("ID_PEDIDO")]
        public int IdPedido { get; set; }

        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }

        [Column("CANTIDAD")]
        public int Cantidad { get; set; }

        [Column("TOTAL_LINEA")]
        public int TotalLinea { get; set; }
    }
}
