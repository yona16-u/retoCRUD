using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retoCRUD.DATOS
{
    public class Conexion
    {//DATOSN PARA CONECTAR CON motor de base de datos SQL 
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {//COMUNICACION CON BD
            this.Base = "BD_ContosoSA";
            this.Servidor = "DESKTOP-VF72J7C\\SQLEXPRESS";
            this.Usuario = "user_dj";
            this.Clave = "162407";

        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor +
                                                        "; Database=" + this.Base +
                                                        "; User Id=" + this.Usuario +
                                                        "; Password= " + this.Clave;
            }
            catch (Exception ex)//en caso de ERROR 
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion getInstancia()//verificacion
        {
            if (Con == null)//si no esta conectada
            {
                Con = new Conexion();//crea nueva conexion
            }
            return Con;//sino retorna a al conexion establecida
        }

    }
}
