using System;
//Referencias >>
using HTMLtoTXT;

namespace DLLTester
{
    class Test
    {
        static void Main()
        {
            //Aplicacion tipo consola.
            //Para hacer la prueba de la DLL, hay que instanciar la clase a usar y ejecutar el metodo deseado. EJ:
            //Fundamental agregar la referencia a este proyecto, ya que sino la clase no sera visible.
            Conversor convert = new Conversor();
            Console.WriteLine(convert.NumeroComprobante(@"C:\Users\julian.lastra\Desktop\T\a.html"));
            Console.WriteLine(convert.FechaPago(@"C:\Users\julian.lastra\Desktop\T\a.html"));
            Console.WriteLine(convert.Recaudacion(@"C:\Users\julian.lastra\Desktop\T\a.html"));
            Console.WriteLine(convert.Comision(@"C:\Users\julian.lastra\Desktop\T\a.html"));
            Console.WriteLine(convert.Percepcion(@"C:\Users\julian.lastra\Desktop\T\a.html"));
            Console.WriteLine(convert.IVAs(@"C:\Users\julian.lastra\Desktop\T\a.html"));

            Console.WriteLine("\r\n");

            Console.WriteLine(convert.NumeroComprobante(@"C:\Users\julian.lastra\Desktop\T\D.html"));
            Console.WriteLine(convert.FechaPago(@"C:\Users\julian.lastra\Desktop\T\D.html"));
            Console.WriteLine(convert.Recaudacion(@"C:\Users\julian.lastra\Desktop\T\D.html"));
            Console.WriteLine(convert.Comision(@"C:\Users\julian.lastra\Desktop\T\D.html"));
            Console.WriteLine(convert.Percepcion(@"C:\Users\julian.lastra\Desktop\T\D.html"));
            Console.WriteLine(convert.IVAs(@"C:\Users\julian.lastra\Desktop\T\D.html"));

            Console.WriteLine("\r\n");

            Console.WriteLine(convert.NumeroComprobante(@"C:\Users\julian.lastra\Desktop\T\B.html"));
            Console.WriteLine(convert.FechaPago(@"C:\Users\julian.lastra\Desktop\T\B.html"));
            Console.WriteLine(convert.Recaudacion(@"C:\Users\julian.lastra\Desktop\T\B.html"));
            Console.WriteLine(convert.Comision(@"C:\Users\julian.lastra\Desktop\T\B.html"));
            Console.WriteLine(convert.Percepcion(@"C:\Users\julian.lastra\Desktop\T\B.html"));
            Console.WriteLine(convert.IVAs(@"C:\Users\julian.lastra\Desktop\T\B.html"));

            Console.WriteLine("\r\n");

            Console.WriteLine(convert.NumeroComprobante(@"C:\Users\julian.lastra\Desktop\T\C.html"));
            Console.WriteLine(convert.FechaPago(@"C:\Users\julian.lastra\Desktop\T\C.html"));
            Console.WriteLine(convert.Recaudacion(@"C:\Users\julian.lastra\Desktop\T\C.html"));
            Console.WriteLine(convert.Comision(@"C:\Users\julian.lastra\Desktop\T\C.html"));
            Console.WriteLine(convert.Percepcion(@"C:\Users\julian.lastra\Desktop\T\C.html"));
            Console.WriteLine(convert.IVAs(@"C:\Users\julian.lastra\Desktop\T\C.html"));

            Console.WriteLine("\r\n");

            Console.WriteLine(convert.NumeroComprobante(@"C:\Users\julian.lastra\Desktop\T\E.html"));
            Console.WriteLine(convert.FechaPago(@"C:\Users\julian.lastra\Desktop\T\E.html"));
            Console.WriteLine(convert.Recaudacion(@"C:\Users\julian.lastra\Desktop\T\E.html"));
            Console.WriteLine(convert.Comision(@"C:\Users\julian.lastra\Desktop\T\E.html"));
            Console.WriteLine(convert.Percepcion(@"C:\Users\julian.lastra\Desktop\T\E.html"));
            Console.WriteLine(convert.IVAs(@"C:\Users\julian.lastra\Desktop\T\E.html"));

            Console.WriteLine("\r\n");

            //En caso de que me tenga que entregar un resultado tipo int o string uso la siguiente forma:
            //Console.WriteLine(convert.Extract("texto"));
        }
    }
}
