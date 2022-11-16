using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArtVetController : ControllerBase
    {
        public ArtVetController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }

        [HttpGet]
        public object GetArtVet()
        {
            var obj = from Tbl_ArticulosProductosVeterinarios in new Tbl_ArticulosProductosVeterinarios().Get<Tbl_ArticulosProductosVeterinarios>()
                      select new
                      {
                          IdArtVet = Tbl_ArticulosProductosVeterinarios.id_articulosveterinarios,
                          IdArticulo = Tbl_ArticulosProductosVeterinarios.fk_id_articulos_veterinarios,
                          PresentacionArtVet = Tbl_ArticulosProductosVeterinarios.presentacion_articulosveterinarios,
                          PrecioArtVet = Tbl_ArticulosProductosVeterinarios.precio_articulosveterinarios,
                          FechaArtVet = Tbl_ArticulosProductosVeterinarios.fecha_vencimiento,
                          CaracteristicasArtVet = Tbl_ArticulosProductosVeterinarios.caracteristicas_articulosveterinarios,
                          IdMarcaArtVet = Tbl_ArticulosProductosVeterinarios.fk_id_marca_articulosveterinarios
                      };
            return obj;

        }

        [HttpPost]
        public object SaveArtVet(Tbl_ArticulosProductosVeterinarios newArtVet)
        {
            return newArtVet.id_articulosveterinarios = (int)newArtVet.Save();
        }

    }
}
