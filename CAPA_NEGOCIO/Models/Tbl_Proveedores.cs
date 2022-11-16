using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_Proveedores : EntityClass
    {
        public int? id_proveedor { get; set; }
        public string nombre_proveedor { get; set; }
        public string telefono_proveedor { get; set; }
        public string correo_proveedor { get; set; }
    }
}
