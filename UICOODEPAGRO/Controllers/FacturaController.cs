using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        public FacturaController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }
        [HttpGet]
        public object GetFactura()
        {
            var obj = from Tbl_Factura in new Tbl_Factura().Get<Tbl_Factura>()
                      select new
                      {
                          IdFactura = Tbl_Factura.id_factura,
                          IdCliente = Tbl_Factura.fk_id_cliente_factura,
                          IdPersonal = Tbl_Factura.fk_id_personal_factura,
                          FechaFactura = Tbl_Factura.fecha_factura,
                          SubTotalFactura = Tbl_Factura.subtotal_factura,
                          IvaFactura = Tbl_Factura.iva_factura,
                          TotalFactura = Tbl_Factura.total_factura
                      };
            return obj;
        }
        [HttpPost]
        public object SaveFactura(Tbl_Factura newFactura)
        {
            return newFactura.id_factura = (int)newFactura.Save();
        }
    }
}
