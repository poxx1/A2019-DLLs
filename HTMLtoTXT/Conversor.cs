using System;
using System.IO;

namespace HTMLtoTXT
{
    public class Conversor
    {
        //Extraigo texto en particular que necesite desde un archivo
        public string Extract(string input)
        {
            StreamReader sr = new StreamReader(input);
            var num = sr.ReadToEnd().Split(new[] { "texto" }, StringSplitOptions.None);
            return num[0];
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
