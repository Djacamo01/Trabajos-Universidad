using System;



namespace ConsoleApp1{
    public class Estudiante: {
        private string carnet;
        private string carrera;
        private string facultad;
        private string semestre;
        private string materia;
        private string seccion;
        private string profesor;
        private float promedio;
        private float nota1parcial;
        private float nota2parcial;
        private float nota3parcial;
        private float notaFinal;

        public string Carnet {
            get { return carnet; }
            set { carnet = value; }
        }

        public string Carrera {
            get { return carrera; }
            set { carrera = value; }
        }

        public string Facultad {
            get { return facultad; }
            set { facultad = value; }
        }

        public string Semestre {
            get { return semestre; }
            set { semestre = value; }
        }

        public string Materia {
            get { return materia; }
            set { materia = value; }
        }

        public string Seccion {
            get { return seccion; }
            set { seccion = value; }
        }

        public string Profesor {
            get { return profesor; }
            set { profesor = value; }
        }

        public float Promedio {
            get { return promedio; }
            set { promedio = value; }
        }

        public float Nota1Parcial {
            get { return nota1parcial; }
            set { nota1parcial = value; }
        }

        public float Nota2Parcial {
            get { return nota2parcial; }
            set { nota2parcial = value; }
        }

        public float Nota3Parcial {
            get { return nota3parcial; }
            set { nota3parcial = value; }
        }

        public float NotaFinal {
            get { return notaFinal; }
            set { notaFinal = value; }
        }


    }
}