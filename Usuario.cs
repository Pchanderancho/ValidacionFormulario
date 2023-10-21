using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroLoginAjax
{
    public class Usuario
    {
        private string rut;
        private string nombre;
        private string apellido;
        private string clave;

        public Usuario()
        {
        }

        public Usuario(string rut, string nombre, string apellido, string clave)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
        }

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}