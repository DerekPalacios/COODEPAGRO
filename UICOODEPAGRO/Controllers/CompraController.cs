using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        public CompraController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }
        [HttpGet]
        public object GetCompra()
        {
            var obj = from Tbl_CompraArticulo in new Tbl_CompraArticulo().Get<Tbl_CompraArticulo>()
                      select new
                      {
                          IdCompra = Tbl_CompraArticulo.id_compraarticulo,
                          IdProveedor = Tbl_CompraArticulo.fk_id_proveedor_compraarticulo,
                          FechaCompra = Tbl_CompraArticulo.fecha_compraarticulo,
                          SubTotalCompra = Tbl_CompraArticulo.subtotal_compraarticulo,
                          IvaCompra = Tbl_CompraArticulo.iva_compraarticulo,
                          TotalCompra = Tbl_CompraArticulo.total_compraarticulo,
                      };
            return obj;
        }
        [HttpPost]
        public object SaveCompra(Tbl_CompraArticulo newCompra)
        {
            return newCompra.id_compraarticulo = (int)newCompra.Save();
        }
    }
}
