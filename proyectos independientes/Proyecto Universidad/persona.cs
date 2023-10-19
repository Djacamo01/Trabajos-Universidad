using System;

namespace ConsoleApp1{

    public class Persona{
        private string nombre;
        private string apellido;
        private int edad;
        private string cedula;
        private string direccion;
        private string telefono;

                public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad {
            get { return edad; }
            set { edad = value; }
        }

        public string Cedula {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Direccion {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono {
            get { return telefono; }
            set { telefono = value; }
        }

    }


}