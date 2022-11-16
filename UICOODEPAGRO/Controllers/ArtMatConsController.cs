using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArtMatConsController : ControllerBase
    {
        public ArtMatConsController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }
        [HttpGet]
        public object GetArtMat()
        {
            var obj = from Tbl_ArticulosMaterialesConstruccion in new Tbl_ArticulosMaterialesConstruccion().Get<Tbl_ArticulosMaterialesConstruccion>()
                      select new
                      {
                          IdMatCons = Tbl_ArticulosMaterialesConstruccion.id_articulosConstruccion,
                          IdArticulo = Tbl_ArticulosMaterialesConstruccion.id_articulosConstruccion,
                          PresentacionMatCons = Tbl_ArticulosMaterialesConstruccion.presentacion_articulosConstruccion,
                          PrecioMatCons = Tbl_ArticulosMaterialesConstruccion.precio_articulosConstruccion,
                          FechaMatCons = Tbl_ArticulosMaterialesConstruccion.fecha_vencimiento,
                          IdMarcaMatCons = Tbl_ArticulosMaterialesConstruccion.fk_id_marca_articulosConstruccion
                      };
             return obj;
        }
        [HttpPost]
        public object SaveMatCons(Tbl_ArticulosMaterialesConstruccion newMatCons) 
        {
            return newMatCons.id_articulosConstruccion = (int)newMatCons.Save();
        
        }



    }
}
