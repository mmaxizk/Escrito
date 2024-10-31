using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entidades;
using System.Data;

namespace capaDatos
{
    public class CD_Venta
    {
        private Conexion conn = new Conexion();
        private MySqlCommand comando = new MySqlCommand();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();
        public void AgregarVenta(int precio, int iva, int descuento, int precioTotal, int idPropiedad)
        {
            try
            {
                comando.Connection = Conexion.Conectarse();
                comando.CommandText = "INSERT INTO venta (precio, iva, descuento, precio_total, idPropiedad) VALUES (@precio, @iva, @descuento, @precioTotal, @idPropiedad)";
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@iva", iva);
                comando.Parameters.AddWithValue("@descuento", descuento);
                comando.Parameters.AddWithValue("@precioTotal", precioTotal);
                comando.Parameters.AddWithValue("@idPropiedad", idPropiedad);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la venta: " + ex.Message);
            }
            finally
            {
                comando.Parameters.Clear();
                Conexion.Desconectarse();
            }
        }





    }
}
