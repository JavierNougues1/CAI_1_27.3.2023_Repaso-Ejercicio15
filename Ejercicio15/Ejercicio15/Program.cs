// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Usuario: JAVIER
                //Contraseña: JAVIER123
                Usuario usuarioActual = new Usuario();
                Console.Clear();
                string usuario = Validacion.UsuarioNoVacio("Bienvenido! \nPor favor, ingrese su usuario: \nRecuerde que el mismo debe contener, por lo menos, 5 caracteres:");
                string contraseña = Validacion.ContraseñaNoVacia("Por favor, ingrese su contraseña");
                if (Usuario.LeerUsuario(usuario, contraseña))
                {
                    Console.Clear();
                    usuarioActual.MostrarUsuario();
                }

            } while (true);

            
        }
    }


}
