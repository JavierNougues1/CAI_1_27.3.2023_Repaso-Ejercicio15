using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Usuario
    {
        public string NombreUsuario { get; }
        public string ContraseñaUsuario { get; }

        const string maestroUsuarios = "maestroUsuarios.txt";

        static List<Usuario> usuarios = new List<Usuario>();

        public Usuario() { }
        public Usuario(string linea)
        {
            var datos = linea.Split('|');
            NombreUsuario = datos[0];
            ContraseñaUsuario = datos[1];
        }

        public static bool LeerUsuario(string usuarioIngresado, string contraseñaIngresada)
        {
            if (File.Exists(maestroUsuarios))
            {
                using (var reader = new StreamReader(maestroUsuarios))
                {
                    bool us = false;
                    bool con = false;
                    while (!reader.EndOfStream)
                    {
                        var linea = reader.ReadLine();
                        var usuario = new Usuario(linea);

                        us = usuario.NombreUsuario == usuarioIngresado.ToUpper();
                        con = usuario.ContraseñaUsuario == contraseñaIngresada.ToUpper();

                        if (us == true && con == true)
                        {
                            usuarios.Add(usuario);
                            break;
                        }
                    }
                    if (us == false || con == false)
                    {
                        Console.WriteLine("Usario o contraseña inválida. Intente nuevamnete: ");
                        Console.WriteLine("Presione cualquier tecla para continuar:");
                        Console.ReadKey();
                    }
                }
            }
            return true;
        }
        public void MostrarUsuario()
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                Console.WriteLine($"Bienvenido { usuarios[i].NombreUsuario}");
            }
            Console.WriteLine("Presione cualquier tecla para continuar:");
            Console.ReadKey();
        }
    }
}
