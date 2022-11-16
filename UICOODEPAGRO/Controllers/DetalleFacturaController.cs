using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DetalleFacturaController : ControllerBase
    {
        public DetalleFacturaController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }
        [HttpGet]
        public object GetDetalleFactura()
        {
            var obj = from Tbl_DetalleFactura in new Tbl_DetalleFactura().Get<Tbl_DetalleFactura>()
                      select new
                      {
                          IdDetalleFactura = Tbl_DetalleFactura.id_detallefactura,
                          IdFactura = Tbl_DetalleFactura.fk_id_factura_detallefactura,
                          IdArticulo = Tbl_DetalleFactura.fk_id_articulo_detallefactura,
                          CantidadDetalleFactura = Tbl_DetalleFactura.cantidad_detallefactura
                      };
            return obj;
        }

        [HttpPost]
        public object SaveDetalleFactura(Tbl_DetalleFactura newDetalleFactura)
        {
            return newDetalleFactura.id_detallefactura = (int)newDetalleFactura.Save();
        }
    }
}
