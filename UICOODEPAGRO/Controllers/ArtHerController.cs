using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArtHerController : ControllerBase
    {
        public ArtHerController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }
        [HttpGet]
        public object GetArtHer()
        {
            var obj = from Tbl_ArticulosHerramientas in new Tbl_ArticulosHerramientas().Get<Tbl_ArticulosHerramientas>()
                      select new
                      {
                          IdArtHer = Tbl_ArticulosHerramientas.id_articulosherramientas,
                          IdArticulo = Tbl_ArticulosHerramientas.fk_id_articulos_herramientas,
                          PresentacionArtHer = Tbl_ArticulosHerramientas.presentacion_articulosherramientas,
                          PrecioArtHer = Tbl_ArticulosHerramientas.precio_articulosherramientas,
                          CaracteristicasArtHer = Tbl_ArticulosHerramientas.caracteristicas_articulosherramientas,
                          IdMarcaArtHer = Tbl_ArticulosHerramientas.fk_id_marca_articulosherramientas
                      };
            return obj;
        }

        [HttpPost]
        public object SaveArtHer(Tbl_ArticulosHerramientas newArtHer)
        {
            return newArtHer.id_articulosherramientas = (int)newArtHer.Save();
        }
    }
}
