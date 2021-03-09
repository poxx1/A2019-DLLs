using System;
using System.IO;

namespace HTMLtoTXT
{
    public class Conversor
    {
        public void Convert(string input,string output)
        {
            StreamReader srd = new StreamReader(input);
            var txt = srd.ReadToEnd();
            StreamWriter sw = new StreamWriter(output);
            sw.Write(txt);
            sw.Close();
        }
    }
}
