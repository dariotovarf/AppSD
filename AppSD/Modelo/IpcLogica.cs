using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using AppSD.Modelo;
using System.Data.SQLite;


namespace AppSD.Logica
{
    public class IpcLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static IpcLogica _instancia = null;

        public IpcLogica()
        {

        }

        public static IpcLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new IpcLogica();
                }
                return _instancia;
            }
        }

        public List<Ipc> ListarIPC()
        {

            Ipc ipc = new Ipc() { Id = 0, Mes = "--Seleccione una Opcion--", Valor = 0.0 };
            List<Ipc> lista = new List<Ipc>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "SELECT id, mes, valor FROM ipc";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        lista.Add(new Ipc()
                        {
                            Id = int.Parse(dr["id"].ToString()),
                            Mes = dr["mes"].ToString(),
                            Valor = double.Parse(dr["valor"].ToString()),
                        });
                    }
                    lista.Insert(0, ipc);
                }


                conexion.Close();


            }
            return lista;
        }

        public double mesIndexar(int idIpc)
        {

            double Valor = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "SELECT valor FROM ipc WHERE id = '" + idIpc + "'";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {


                        //  Id = int.Parse(dr["id"].ToString()),
                        //  Mes = dr["mes"].ToString(),
                        Valor = double.Parse(dr["valor"].ToString());

                    }
                }


                conexion.Close();


            }
            return Valor;
        }

    }
}