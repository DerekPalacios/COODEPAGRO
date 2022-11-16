using CAPA_DATOS;
using CAPA_NEGOCIO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.security
{
    public class AuthNetCore
    {
        static public UserModel User;
        static public bool VerifyAuthenticate()
        {
            if (SqlADOConexion.SQLM == null)
            {
                SqlADOConexion.SQLM = null;
                return false;
            }
            return true;
        }
        static public bool loginIN(string user, string password)
        {
            try
            {
                SqlADOConexion.IniciarConexion(user, password);
                //User = new UserModel(
                //    new TblUsuario() { NombreUsuario = user }.FindObject<TblUsuario>()
                //);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    public class UserModel
    {
        public UserModel(Tbl_Personal usuario)
        {
            this.user = usuario.usuario_personal;
            this.success = true;
            this.UserId = usuario.id_personal;
            this.Roles = new List<String> { "Admin", "Vendedor", "Comprador" };
        }
        public string user { get; set; }
        public int? UserId { get; set; }
        public bool success { get; set; }
        public List<String> Roles { get; set; }
    }


}
