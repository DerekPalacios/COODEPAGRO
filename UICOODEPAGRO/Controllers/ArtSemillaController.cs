using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArtSemillaController : ControllerBase
    {
        public ArtSemillaController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }

        [HttpGet]
        public object GetArtSemilla()
        {
            var obj = from Tbl_Articulossemillas in new Tbl_Articulossemillas().Get<Tbl_Articulossemillas>()
                      select new
                      {
                          IdSemilla = Tbl_Articulossemillas.id_articulossemillas,
                          IdArtSemilla = Tbl_Articulossemillas.fk_id_articulos_semillas,
                          PresentacioArtSem = Tbl_Articulossemillas.presentacion_articulossemillas,
                          UMedidaArtSemilla = Tbl_Articulossemillas.unidaddemedida_articulossemillas,
                          PrecioArtSemilla = Tbl_Articulossemillas.precio_articulossemillas,
                          CaracteristicasArtSemillas = Tbl_Articulossemillas.caracteristicas_articulossemillas,
                          IdMarcaSemilla = Tbl_Articulossemillas.fk_id_marca_articulossemillas
                      };
            return obj;
        }

        [HttpPost]
        public object SaveSemilla(Tbl_Articulossemillas newSemilla)
        {
            return newSemilla.id_articulossemillas = (int)newSemilla.Save();
        }

    }
}
