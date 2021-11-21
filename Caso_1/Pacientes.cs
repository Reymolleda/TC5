using System;
using System.Collections.Generic;
using System.Text;

namespace Caso_1
{
    class Pacientes
    {
        public int id;
        public string nombre, apellido;

        public Pacientes(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
