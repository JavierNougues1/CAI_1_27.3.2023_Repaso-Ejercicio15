using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Validacion
    {
        static public string UsuarioNoVacio(string mensaje)
        {
            string usuarioIngresado = "";
            do
            {
                Console.WriteLine(mensaje);
                usuarioIngresado = Console.ReadLine();
                if (usuarioIngresado.Length == 0 || usuarioIngresado.Length < 5)
                {
                    Console.Clear();
                    Console.WriteLine("Por favor, ingrese un usuario válido:");
                    continue;
                }
                break;
            } while (true);
            return usuarioIngresado;
        }
        static public string ContraseñaNoVacia(string mensaje)
        {
            string contraseñaingresada = "";
            do
            {
                Console.WriteLine(mensaje);
                contraseñaingresada = Console.ReadLine();
                if (contraseñaingresada.Length == 0 || contraseñaingresada.Length < 8)
                {
                    Console.Clear();
                    Console.WriteLine("Por favor, ingrese una contraseña válida:");
                    continue;
                }
                break;
            } while (true);
            return contraseñaingresada;
        }
    }
}
