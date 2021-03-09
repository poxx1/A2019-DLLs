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
            convert.Convert("ruta1","ruta2");

            //En caso de que me tenga que entregar un resultado tipo int o string uso la siguiente forma:
            Console.WriteLine(convert.Extract("texto"));
        }
    }
}
