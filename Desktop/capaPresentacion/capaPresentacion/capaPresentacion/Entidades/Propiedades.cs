using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{



    public class Propiedades
    {
        // Atributos privados
        private int id;
        private string tipo;
        private string direccion;
        private int metrosCuadrados;  // Precio como entero
        private int precio;


        // Propiedades (Getters y Setters)
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int MetrosCuadrados
        {
            get { return metrosCuadrados; }
            set { metrosCuadrados = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }

}
    



