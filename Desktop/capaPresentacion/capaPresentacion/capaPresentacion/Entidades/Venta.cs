using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
        public class Venta
        {
      
        private int id;
        private int precio;           
        private int cantidad;
        private int iva;              
        private int precioTotal;
        private int idPropiedad;
        private int descuento;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public int Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        public int PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }

        public int IdPropiedad
        {
            get { return idPropiedad; }
            set { idPropiedad = value; }
        }

    }
    }

