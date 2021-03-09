using System;
using System.IO;

namespace HTMLtoTXT
{
    public class Conversor
    {
        public string Extract(string input)
        {
            StreamReader sr = new StreamReader(input);
            var num = sr.ReadToEnd().Split(new[] { "texto" }, StringSplitOptions.None);
            return num[0];
        }

        public void Convert(string input,string output)
        {
            StreamReader srd = new StreamReader(input);
            var txt = srd.ReadToEnd();
            StreamWriter sw = new StreamWriter(output);
            sw.Write(txt);
            sw.Close();
        }
     
        public string Splitter(string texto)
        {
            var str = texto.Split(new[] { "texto" }, StringSplitOptions.None);
            return str[0];
        }
    }
}
