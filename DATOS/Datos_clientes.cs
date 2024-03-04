using retoCRUD.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retoCRUD.DATOS
{
    public class Datos_clientes
    {//INTERACCION BD --> C#
        #region "Clientes"
        public DataTable Lectura_cli(string cTexto)
        {//RECURSOS
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try //en caso de ERROR!!
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //Tarea de Lectura
                SqlCommand Comando = new SqlCommand("SP_LECTURA_CLIENTE", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();

                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)    //retener
            {
                throw ex;                //mostrar error
            }
            finally                         //  al final la conexion debe cerrarse
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public string Cr_Up_cli(int nOpcion, E_clientes oProp)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SP_CR_UPCLIENTE", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                //DEFINICION DE PARAMETROS
                Comando.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@nId_Cliente", SqlDbType.Int).Value = oProp.IdCliente;
                Comando.Parameters.Add("@nDni_cliente", SqlDbType.Decimal).Value = oProp.Dni;
                Comando.Parameters.Add("@cNombre_cliente", SqlDbType.VarChar).Value = oProp.Nombre;
                Comando.Parameters.Add("@cApellido_cliente", SqlDbType.VarChar).Value = oProp.Apellido;
                Comando.Parameters.Add("@nTelefono_cliente", SqlDbType.Decimal).Value = oProp.Telefono;
                Comando.Parameters.Add("@cDireccion_cliente", SqlDbType.VarChar).Value = oProp.Direccion;
                Comando.Parameters.Add("@nCodGrupo", SqlDbType.Int).Value = oProp.CodGrupo;
                Comando.Parameters.Add("@nCoddoc", SqlDbType.Int).Value = oProp.CodDoc;
                SqlCon.Open();
                //VERIFICACION
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo registrar los datos";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string Del_activo_cli(int nIdCliente,
                                                bool bEstado_activo)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SP_DEL_activo_CLIENTE", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                //DEFINICION DE PARAMETROS
                Comando.Parameters.Add("@nId_Cliente", SqlDbType.Int).Value = nIdCliente;
                Comando.Parameters.Add("@bEstado_activo", SqlDbType.Int).Value = bEstado_activo;

                SqlCon.Open();
                //VERIFICACION
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo cambiar el estado activo";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        #endregion
        public DataTable Lectura_Grupo()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //Tarea de Lectura Grupo
                SqlCommand Comando = new SqlCommand("SP_LECTURA_GRUPO", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();

                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)    //retener
            {
                throw ex;                //mostrar error
            }
            finally                         //  al final la conexion debe cerrarse
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable Lectura_Doc()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                //Tarea de Lectura Documentos
                SqlCommand Comando = new SqlCommand("SP_LECTURA_DOC", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();

                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)    //retener
            {
                throw ex;                //mostrar error
            }
            finally                         //  al final la conexion debe cerrarse
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
