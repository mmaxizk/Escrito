using capaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
    public class CL_Venta
    {
        private CD_Venta DatosVenta = new CD_Venta();



        public void RealizarVenta(int idPropiedad, int precio, string tipoPropiedad, int iva)
        {
            // Aplicar descuento adicional del 15% si la propiedad es tipo "terreno"
            int descuentoAdicional = tipoPropiedad.ToLower() == "terreno" ? (precio * 15 / 100) : 0;

            // Calcular subtotal, IVA y descuentos
            int subtotal = precio;
            int montoIVA = subtotal * iva / 100;
            int montoDescuento = descuentoAdicional;
            int precioTotal = subtotal + montoIVA - montoDescuento;

            // Registrar la venta en la base de datos
            DatosVenta.AgregarVenta(precio, iva, montoDescuento, precioTotal, idPropiedad);

            // Generar el PDF de la venta
            GenerarPDF(precioTotal, tipoPropiedad, iva, montoDescuento, precio);
        }

        private void GenerarPDF(int precioTotal, string tipoPropiedad, int iva, int descuento, int precio)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaPDF = System.IO.Path.Combine(rutaEscritorio, "venta_propiedad.pdf");

            using (var doc = new iTextSharp.text.Document())
            {
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new System.IO.FileStream(rutaPDF, System.IO.FileMode.Create));
                doc.Open();
                doc.Add(new iTextSharp.text.Paragraph("Detalles de la Venta de Propiedad"));
                doc.Add(new iTextSharp.text.Paragraph($"Tipo de Propiedad: {tipoPropiedad}"));
                doc.Add(new iTextSharp.text.Paragraph($"Precio Unitario: {precio}"));
                doc.Add(new iTextSharp.text.Paragraph($"IVA: {iva}%"));
                doc.Add(new iTextSharp.text.Paragraph($"Descuento Total: {descuento}"));
                doc.Add(new iTextSharp.text.Paragraph($"Total: {precioTotal}"));
                doc.Close();
            }
        }



    }



}
