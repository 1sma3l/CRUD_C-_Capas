using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    class Conexion
    {
        private SqlConnection conexion = new SqlConnection("Server=localhost;Database=Inicial;Trusted_Connection=True;");

        public SqlConnection AbrirConexion()
        {
            if(conexion.State == ConnectionState.Closed)
            {
                conexion.Open(); 
            }
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
