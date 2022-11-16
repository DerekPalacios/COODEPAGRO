using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DetalleCompraController : ControllerBase
    {
        public DetalleCompraController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }

        [HttpGet]
        public object GetDetalleCompra()
        {
            var obj = from Tbl_DetalleCompraArticulo in new Tbl_DetalleCompraArticulo().Get<Tbl_DetalleCompraArticulo>()
                      select new
                      {
                          IdDetalleCompra = Tbl_DetalleCompraArticulo.id_detallecompra,
                          IdCompra = Tbl_DetalleCompraArticulo.fk_id_compraarticulo_detalle,
                          IdArticulo = Tbl_DetalleCompraArticulo.fk_id_articulo_detalle,
                          CantidadCompra = Tbl_DetalleCompraArticulo.cantidad_detalle
                      };
            return obj;
        }
        [HttpPost]
        public object SaveDetalleCompra(Tbl_DetalleCompraArticulo newDetalleCompra)
        {
            return newDetalleCompra.id_detallecompra = (int)newDetalleCompra.Save();
        }

    }
}
