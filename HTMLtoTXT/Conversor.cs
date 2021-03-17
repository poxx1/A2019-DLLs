using System;
using System.IO;

namespace HTMLtoTXT
{
    public class Conversor
    {
        //Extraigo texto en particular que necesite desde un archivo
        //No seas pelotudo, usa trycatch.
        public string NumeroComprobante(string input)
        {

            try
            {
                StreamReader sr = new StreamReader(input);
                var num = sr.ReadToEnd().Split(new[] { "<TD class=b>" }, StringSplitOptions.None);
                var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
                return fechaPago[0];
            }
            catch (Exception ex)
            {
                return "Error al procesar el archivo";
            }
        }
        public string FechaPago(string input)
        {
            try { 
            StreamReader sr = new StreamReader(input);
            var num = sr.ReadToEnd().Split(new[] { "FECHA DE PAGO</TD>" }, StringSplitOptions.None);
            var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
            return fechaPago[0].Replace("<TD width=20%>","");
        }
            catch (Exception ex)
            {
                return "Error al procesar el archivo";
            }
}
        public string Recaudacion(string input)
        {
            try { 
            StreamReader sr = new StreamReader(input);
            var num = sr.ReadToEnd().Split(new[] { "RECAUDACION</TD>" }, StringSplitOptions.None);
            var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
            return fechaPago[0].Replace("<TD width=20%>", "");
            }
            catch (Exception ex)
            {
                return "Error al procesar el archivo";
            }
        }
        public string Comision(string input)
        {
            try { 
            StreamReader sr = new StreamReader(input);
            var num = sr.ReadToEnd().Split(new[] { "=tt>COMISION</TD>" }, StringSplitOptions.None);
            var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
            return fechaPago[0].Replace("<TD width=20%>", "");
            }
            catch (Exception ex)
            {
                return "Error al procesar el archivo";
            }
        }
        public string Percepcion(string input)
        {
            try
            {
                StreamReader sr = new StreamReader(input);
                var num = sr.ReadToEnd().Split(new[] { "RG 3337</TD>" }, StringSplitOptions.None);
                var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
                return fechaPago[0].Replace("<TD>", "");
            }
            catch (Exception ex)
            {
                return "Error al procesar el archivo";
            }
}
        public string IVAs(string input)
        {
            try
            {
                StreamReader sr = new StreamReader(input);
                var num = sr.ReadToEnd().Split(new[] { "I.V.A. S/COMISION</TD>" }, StringSplitOptions.None);
                var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
                return fechaPago[0].Replace("<TD width=20%>", "");
            }
            catch (Exception ex)
            {
                return "Error al procesar el archivo";
            }
        }

        //Tomo un .html lo convierto a .txt y lo guardo en alguna ubicacion.
        public void Convert(string input,string output)
        {
            StreamReader srd = new StreamReader(input);
            var txt = srd.ReadToEnd();
            StreamWriter sw = new StreamWriter(output);
            sw.Write(txt);
            sw.Close();
        }
     
        //Split de un texto especifico.
        public string Splitter(string texto)
        {
            var str = texto.Split(new[] { "texto" }, StringSplitOptions.None);
            return str[0];
        }
    }
}
