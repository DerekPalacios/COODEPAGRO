using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_Marca : EntityClass
    {
        public int? id_marca { get; set; }
        public string nombre { get; set; }
    }
}
