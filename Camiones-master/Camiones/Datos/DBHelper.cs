using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camiones.Entidades;

namespace Camiones.Datos
{
    public class DBHelper
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        //private SqlDataReader lector;
        public DBHelper()
        {
            conexion = new SqlConnection(@"Data Source=pablo-mina;Initial Catalog=Camion2;Integrated Security=True");
        }
        public int ProximoCamion()
        {
            int aux = 0;
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMO_CAMION";
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

            conexion.Close();

            return aux;
        }

        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        public DataTable ConsultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        public DataTable Consultar(string nombreSP, List<Parametro> lstParametros)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();
            foreach (Parametro p in lstParametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public bool ConfirmarCarga(Camione nuevoCamion)
        {
            bool resultado = true;

            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_CAMION";
                comando.Parameters.AddWithValue("@patente", nuevoCamion.Patente);
                comando.Parameters.AddWithValue("@estadoCamion", nuevoCamion.estadoCamion);
                comando.Parameters.AddWithValue("@pesoMax", nuevoCamion.pesoMaximo);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@proxCamion";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int presupuestoNro = (int)parametro.Value;
                int CargaNro = 1;
                SqlCommand cmdDetalle;

                foreach (TipoCarga tp in nuevoCamion.listaCargas)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_CARGA", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@idCamion", tp.Camione.idCamion);
                    cmdDetalle.Parameters.AddWithValue("@pesoCarga", tp.CalcularSubtotal());
                    cmdDetalle.Parameters.AddWithValue("@tipoCarga", tp.Carga.tipoCarga);
                    cmdDetalle.ExecuteNonQuery();
                    CargaNro++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }
    }
}
