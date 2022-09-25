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
    public class DescuentoLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static DescuentoLogica _instancia = null;

        public DescuentoLogica()
        {

        }

        public static DescuentoLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DescuentoLogica();
                }
                return _instancia;
            }
        }

        public List<Descuento> Listar(string fechaIni, string fechaFin, string id)
        {


            List<Descuento> lista = new List<Descuento>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();


                if (id == "")
                {
                    long sumaBase = 0;
                    long sumaDesc = 0;
                    int contador = 0;
                    string query = "SELECT * FROM descuento WHERE fecha >='" + fechaIni + "' AND fecha <='" + fechaFin + "'";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Descuento()
                            {
                                Fecha = dr["fecha"].ToString(),
                                Id = dr["id"].ToString(),
                                Nombre = dr["nombre"].ToString(),
                                Base = long.Parse(dr["base"].ToString()),
                                Retencion = long.Parse(dr["desc"].ToString()),

                            });
                            sumaBase += long.Parse(dr["base"].ToString());
                            sumaDesc += long.Parse(dr["desc"].ToString());
                            contador += 1;
                        }
                        lista.Add(new Descuento()
                        {
                            Fecha = "No. Registros",
                            Id = contador.ToString(),
                            Nombre = "Total",
                            Base = sumaBase,
                            Retencion = sumaDesc,

                        });
                    }
                }
                else
                {
                    long sumaBase = 0;
                    long sumaDesc = 0;
                    int contador = 0;
                    string query = "SELECT * FROM descuento WHERE fecha >='" + fechaIni + "' AND fecha <='" + fechaFin + "' AND id ='" + id + "'";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Descuento()
                            {
                                Fecha = dr["fecha"].ToString(),
                                Id = dr["id"].ToString(),
                                Nombre = dr["nombre"].ToString(),
                                Base = long.Parse(dr["base"].ToString()),
                                Retencion = long.Parse(dr["desc"].ToString()),
                            });
                            sumaBase += long.Parse(dr["base"].ToString());
                            sumaDesc += long.Parse(dr["desc"].ToString());
                            contador += 1;
                        }
                        lista.Add(new Descuento()
                        {
                            Fecha = "No. Registros",
                            Id = contador.ToString(),
                            Nombre = "Total",
                            Base = sumaBase,
                            Retencion = sumaDesc,

                        });
                    }


                }
                conexion.Close();
            }
            return lista;
        }

        public List<DescuentoIndexado> ListarIndexado(string fechaIni, string fechaFin, string id, int ipcSeleccionado)
        {

            string fechaDesc = "";
            double valorIndexado = 0;
            double valorIpc = 0;
            double interes = 0;
            double valorIpcIndexar = IpcLogica.Instancia.mesIndexar(ipcSeleccionado);


            List<DescuentoIndexado> listaIndexada = new List<DescuentoIndexado>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                if (id == "")
                {
                    long sumaBase = 0;
                    long sumaDesc = 0;
                    double sumaInteres = 0;
                    double sumaIndexado = 0;
                    int contador = 0;
                    string queryDesc = "SELECT * FROM descuento WHERE fecha >='" + fechaIni + "' AND fecha <='" + fechaFin + "'";
                    SQLiteCommand cmdDesc = new SQLiteCommand(queryDesc, conexion);
                    cmdDesc.CommandType = System.Data.CommandType.Text;

                    string queryIpc = "SELECT * FROM ipc";
                    SQLiteCommand cmdIpc = new SQLiteCommand(queryIpc, conexion);
                    cmdIpc.CommandType = System.Data.CommandType.Text;


                    using (SQLiteDataReader drDesc = cmdDesc.ExecuteReader())
                    {
                        while (drDesc.Read())
                        {
                            using (SQLiteDataReader drIpc = cmdIpc.ExecuteReader())
                            {
                                fechaDesc = drDesc["fecha"].ToString().Substring(0, 7);
                                while (drIpc.Read())
                                {
                                    if (fechaDesc == drIpc["mes"].ToString())
                                    {
                                        valorIpc = double.Parse(drIpc["valor"].ToString());
                                        valorIndexado = (valorIpcIndexar / valorIpc) * long.Parse(drDesc["desc"].ToString());
                                        interes = valorIndexado - long.Parse(drDesc["desc"].ToString());
                                        listaIndexada.Add(new DescuentoIndexado()
                                        {
                                            Fecha = drDesc["fecha"].ToString(),
                                            Id = drDesc["id"].ToString(),
                                            Nombre = drDesc["nombre"].ToString(),
                                            Base = long.Parse(drDesc["base"].ToString()),
                                            Retencion = long.Parse(drDesc["desc"].ToString()),
                                            Actualizacion = interes,
                                            Indexado = valorIndexado,
                                        });

                                        sumaBase += long.Parse(drDesc["base"].ToString());
                                        sumaDesc += long.Parse(drDesc["desc"].ToString());
                                        sumaInteres += interes;
                                        sumaIndexado += valorIndexado;
                                        contador += 1;
                                        drIpc.Close();

                                        break;
                                    }

                                }


                            }

                        }
                        listaIndexada.Add(new DescuentoIndexado()
                        {
                            Fecha = "No. Registros",
                            Id = contador.ToString(),
                            Nombre = "Total",
                            Base = sumaBase,
                            Retencion = sumaDesc,
                            Actualizacion = sumaInteres,
                            Indexado = sumaIndexado,

                        });
                    }
                }
                else
                {
                    long sumaBase = 0;
                    long sumaDesc = 0;
                    double sumaInteres = 0;
                    double sumaIndexado = 0;
                    int contador = 0;
                    string queryDesc = "SELECT * FROM descuento WHERE fecha >='" + fechaIni + "' AND fecha <='" + fechaFin + "' AND id ='" + id + "'";
                    SQLiteCommand cmdDesc = new SQLiteCommand(queryDesc, conexion);
                    cmdDesc.CommandType = System.Data.CommandType.Text;

                    string queryIpc = "SELECT * FROM ipc";
                    SQLiteCommand cmdIpc = new SQLiteCommand(queryIpc, conexion);
                    cmdIpc.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader drDesc = cmdDesc.ExecuteReader())
                    {


                        while (drDesc.Read())
                        {
                            using (SQLiteDataReader drIpc = cmdIpc.ExecuteReader())
                            {
                                fechaDesc = drDesc["fecha"].ToString().Substring(0, 7);
                                while (drIpc.Read())
                                {
                                    if (fechaDesc == drIpc["mes"].ToString())
                                    {
                                        valorIpc = double.Parse(drIpc["valor"].ToString());
                                        valorIndexado = (valorIpcIndexar / valorIpc) * long.Parse(drDesc["desc"].ToString());
                                        interes = valorIndexado - long.Parse(drDesc["desc"].ToString());
                                        listaIndexada.Add(new DescuentoIndexado()
                                        {
                                            Fecha = drDesc["fecha"].ToString(),
                                            Id = drDesc["id"].ToString(),
                                            Nombre = drDesc["nombre"].ToString(),
                                            Base = long.Parse(drDesc["base"].ToString()),
                                            Retencion = long.Parse(drDesc["desc"].ToString()),
                                            Actualizacion = interes,
                                            Indexado = valorIndexado,
                                        });
                                        sumaBase += long.Parse(drDesc["base"].ToString());
                                        sumaDesc += long.Parse(drDesc["desc"].ToString());
                                        sumaInteres += interes;
                                        sumaIndexado += valorIndexado;
                                        contador += 1;
                                        drIpc.Close();

                                        break;
                                    }

                                }
                            }
                        }
                        listaIndexada.Add(new DescuentoIndexado()
                        {
                            Fecha = "No. Registros",
                            Id = contador.ToString(),
                            Nombre = "Total",
                            Base = sumaBase,
                            Retencion = sumaDesc,
                            Actualizacion = sumaInteres,
                            Indexado = sumaIndexado,

                        });
                    }


                }
            }
            return listaIndexada;
        }
    }
}