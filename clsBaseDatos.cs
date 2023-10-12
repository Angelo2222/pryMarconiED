using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryMarconiEDpresentacion
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        //private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Libreria.mdb";
        private string varCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Libreria.mdb";


        public void Listar(DataGridView Grilla)
        {
            try 
            {
                conexion.ConnectionString = varCadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM LIBRO";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Tabla1");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Tabla1"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }
        public void Listar(DataGridView Grilla, String varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;
                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }
    }
   
}
