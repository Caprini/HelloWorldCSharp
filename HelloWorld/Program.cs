using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleColor colorDeLaConsola = ConsoleColor.DarkGreen;

            Console.BackgroundColor = colorDeLaConsola;
            Console.WriteLine("Hellow World! Today is a Good Day! :D");
            Console.ReadLine();

            colorDeLaConsola = ConsoleColor.DarkMagenta;

            string textoBienvenida = "¿Como te va la vida?";
            string otroString = " A mi bien. Muchos porros";

            Console.BackgroundColor = colorDeLaConsola;
            Console.WriteLine(textoBienvenida + otroString);
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("¡¡Ozú que caló!!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();

        }
    }
}
