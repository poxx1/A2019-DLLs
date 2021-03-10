using System;
using System.IO;

namespace HTMLtoTXT
{
    public class Conversor
    {
        //Extraigo texto en particular que necesite desde un archivo
        public string NumeroComprobante(string input)
        {
            StreamReader sr = new StreamReader(input);
            var num = sr.ReadToEnd().Split(new[] { "<TD class=b>" }, StringSplitOptions.None);
            var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
            return fechaPago[0];
        }
        public string FechaPago(string input)
        {
            StreamReader sr = new StreamReader(input);
            var num = sr.ReadToEnd().Split(new[] { "FECHA DE PAGO</TD>" }, StringSplitOptions.None);
            var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
            return fechaPago[0].Replace("<TD width=20%>","");
        }
        public string Recaudacion(string input)
        {
            StreamReader sr = new StreamReader(input);
            var num = sr.ReadToEnd().Split(new[] { "RECAUDACION NETA</TD>" }, StringSplitOptions.None);
            var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
            return fechaPago[0].Replace("<TD width=20%>", "");
        }
        public string Comision(string input)
        {
            StreamReader sr = new StreamReader(input);
            var num = sr.ReadToEnd().Split(new[] { "=tt>COMISION</TD>" }, StringSplitOptions.None);
            var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
            return fechaPago[0].Replace("<TD width=20%>", "");
        }
        public string Percepcion(string input)
        {
            StreamReader sr = new StreamReader(input);
            var num = sr.ReadToEnd().Split(new[] { "RG 3337</TD>" }, StringSplitOptions.None);
            var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
            return fechaPago[0];//.Replace("<TD width=20%>", "");
        }
        public string IVAs(string input)
        {
            StreamReader sr = new StreamReader(input);
            var num = sr.ReadToEnd().Split(new[] { "I.V.A. S/COMISION</TD>" }, StringSplitOptions.None);
            var fechaPago = num[1].Split(new[] { "</TD>" }, StringSplitOptions.None);
            return fechaPago[0].Replace("<TD width=20%>", "");
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
