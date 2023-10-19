using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = "Juan";
            estudiante.Apellido = "Perez";
            estudiante.Edad = 20;
            estudiante.Cedula = "123456789";
            estudiante.Direccion = "Managua";
            estudiante.Telefono = "88888888";
            estudiante.Carnet = "20191000000";
            estudiante.Carrera = "Ingenieria en Sistemas";
            estudiante.Facultad = "FAREM";
            estudiante.Semestre = "1";
            estudiante.Materia = "Programacion I";
            estudiante.Seccion = "A";
            estudiante.Profesor = "Ing. Juan Perez";
            estudiante.Nota1Parcial = 78;
            estudiante.Nota2Parcial = 89;
            estudiante.Nota3Parcial = 65;
            estudiante.Promedio = nota1parcial + nota2parcial + nota3parcial / 3;
            estudiante.NotaFinal = promedio;
            Console.WriteLine($"Nombre: {estudiante.Nombre} {estudiante.Apellido}\nEdad: {estudiante.Edad}\nCedula: {estudiante.Cedula}\nDireccion: {estudiante.Direccion}\nTelefono: {estudiante.Telefono}\nCarnet: {estudiante.Carnet}\nCarrera: {estudiante.Carrera}\nFacultad: {estudiante.Facultad}\nSemestre: {estudiante.Semestre}\nMateria: {estudiante.Materia}\nSeccion: {estudiante.Seccion}\nProfesor: {estudiante.Profesor}\nNota 1er Parcial: {estudiante.Nota1Parcial}\nNota 2do Parcial: {estudiante.Nota2Parcial}\nNota 3er Parcial: {estudiante.Nota3Parcial}\nPromedio: {estudiante.Promedio}\nNota Final: {estudiante.NotaFinal}");
            


        }
    }
}