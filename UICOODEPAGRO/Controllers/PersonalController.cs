using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        public PersonalController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }

        [HttpGet]
        public object GetPersonal()
        {
            var obj = from Tbl_Personal in new Tbl_Personal().Get<Tbl_Personal>()
                      select new
                      {
                          IdPersonal = Tbl_Personal.id_personal,
                          PrimerNombre = Tbl_Personal.primernombre_personal,
                          SegundoNombre = Tbl_Personal.sergundonombre_personal,
                          PrimerApellido = Tbl_Personal.primerapellido_personal,
                          SegundoApellido = Tbl_Personal.segundoapellido_personal,
                          IdCargo = Tbl_Personal.fk_id_cargo_personal,
                          TelefonoPersonal = Tbl_Personal.telefono_personal,
                          CorreoPersonal = Tbl_Personal.correo_personal,
                          UsuarioPersonal = Tbl_Personal.usuario_personal,
                          ContrasenaPersonal = Tbl_Personal.contraseña_personal
                      };
            return obj;
        }
        [HttpPost]
        public object SavePersonal(Tbl_Personal newPersonal)
        {
            return newPersonal.id_personal = (int)newPersonal.Save();
        }
    }
}
