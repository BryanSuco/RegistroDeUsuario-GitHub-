using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeUsuario_GitHub_
{
    public class Usuario
    {
        string Nombre { set; get; }
        string Apellido { set; get; }
        int Edad { set; get; }

        public Usuario()
        {
        }

        public Usuario(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
    }
}
