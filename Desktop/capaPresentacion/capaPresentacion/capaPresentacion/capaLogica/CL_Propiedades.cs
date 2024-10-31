using capaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
    public class CL_Propiedades
    {

        private CD_Propiedades datosElectrodomestico = new CD_Propiedades();

        // Método para mostrar todas las propiedades
        public DataTable MostrarTodasLasPropiedades()
        {
            return datosElectrodomestico.MostrarPropiedades();
        }

        // Método para eliminar una propiedad
        public void EliminarPropiedad(int id)
        {
            datosElectrodomestico.EliminarPropiedad(id);
        }

        // Método para insertar una nueva propiedad
        public void InsertarPropiedad(Propiedades propiedad)
        {
            datosElectrodomestico.InsertarPropiedad(propiedad);
        }

        // Método para actualizar una propiedad existente
        public void ActualizarPropiedad(Propiedades propiedad)
        {
            datosElectrodomestico.ActualizarPropiedad(propiedad);
        }
    }
}
