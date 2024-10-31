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
    public class CD_Propiedades
    {
        // Método para agregar un nuevo electrodoméstico a la base de datos

        private Conexion conn = new Conexion();
        private MySqlCommand comando = new MySqlCommand();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public DataTable MostrarPropiedades()
        {
            DataTable dt = new DataTable();
            try
            {
                comando.Connection = Conexion.Conectarse();
                comando.CommandText = "SELECT * FROM propiedades";
                comando.CommandType = CommandType.Text;

                adapter.SelectCommand = comando;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las propiedades: " + ex.Message);
            }
            finally
            {
                Conexion.Desconectarse();
                comando.Parameters.Clear();
            }
            return dt;
        }

        // Método para eliminar una propiedad
        public void EliminarPropiedad(int id)
        {
            try
            {
                comando.Connection = Conexion.Conectarse();
                comando.CommandText = "DELETE FROM propiedades WHERE id = @id";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la propiedad: " + ex.Message);
            }
            finally
            {
                comando.Parameters.Clear();
                Conexion.Desconectarse();
            }
        }
        // Método para insertar una nueva propiedad
        public void InsertarPropiedad(Propiedades propiedad)
        {
            try
            {
                comando.Connection = Conexion.Conectarse();
                comando.CommandText = "INSERT INTO propiedades (tipo, direccion, m2, precio) VALUES (@tipo, @direccion, @m2, @precio)";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@tipo", propiedad.Tipo);
                comando.Parameters.AddWithValue("@direccion", propiedad.Direccion);
                comando.Parameters.AddWithValue("@m2", propiedad.MetrosCuadrados);
                comando.Parameters.AddWithValue("@precio", propiedad.Precio);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la propiedad: " + ex.Message);
            }
            finally
            {
                comando.Parameters.Clear();
                Conexion.Desconectarse();
            }
        }

        // Método para actualizar una propiedad existente
        public void ActualizarPropiedad(Propiedades propiedad)
        {
            try
            {
                comando.Connection = Conexion.Conectarse();
                comando.CommandText = "UPDATE propiedades SET tipo = @tipo, direccion = @direccion, m2 = @m2, precio = @precio WHERE id = @id";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@id", propiedad.Id);
                comando.Parameters.AddWithValue("@tipo", propiedad.Tipo);
                comando.Parameters.AddWithValue("@direccion", propiedad.Direccion);
                comando.Parameters.AddWithValue("@m2", propiedad.MetrosCuadrados);
                comando.Parameters.AddWithValue("@precio", propiedad.Precio);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la propiedad: " + ex.Message);
            }
            finally
            {
                comando.Parameters.Clear();
                Conexion.Desconectarse();
            }
        }

    }
}
