using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_reparto.Clases
{
    public class Inventario
    {
        //Atributos
        String idInventario;
        String idBodega;
        String idPaquete;
        String idCliente;
        String idEmpleado;
        String cantidad;
        String fecha;

        public Inventario()
        {

        }

        public Inventario(string idInventario, string idBodega, string idPaquete, string idCliente, string idEmpleado, string cantidad, string fecha)
        {
            this.idInventario = idInventario;
            this.idBodega = idBodega;
            this.idPaquete = idPaquete;
            this.idCliente = idCliente;
            this.idEmpleado = idEmpleado;
            this.cantidad = cantidad;
            this.fecha = fecha;
        }

        public string IdInventario { get => idInventario; set => idInventario = value; }
        public string IdBodega { get => idBodega; set => idBodega = value; }
        public string IdPaquete { get => idPaquete; set => idPaquete = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Fecha { get => fecha; set => fecha = value; }

        public List<Object> consulta(String dato)
        {
            MySqlDataReader reader = null;
            List<Object> lista = new List<Object>();
            String sql;

            if (dato == null)
            {
                sql = "SELECT * FROM inventario";
            }
            else
            {
                sql = "SELECT * FROM inventario WHERE idInventario LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarInventario = new MySqlCommand(sql, conexionBD);
                reader = buscarInventario.ExecuteReader();


                while (reader.Read())
                {

                    Inventario inventario = new Inventario();

                    inventario.IdInventario = reader.GetString("idInventario");
                    inventario.IdBodega = reader.GetString("idBodega");
                    inventario.IdPaquete = reader.GetString("idPaquete");
                    inventario.IdCliente = reader.GetString("idCliente");
                    inventario.IdEmpleado = reader.GetString("idEmpleadoMB");
                    inventario.Cantidad = reader.GetString("cantidadInventario");
                    inventario.Fecha = reader.GetString("fechaIngresoInventario");

                    lista.Add(inventario);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;

        }
    }
}
