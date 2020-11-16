using System;
using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;
using CoreEscuela.Util;
using CoreEscuela.App;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENBENIDOS A LA ESCUELA");
            ImprimirCursosEscuela(engine.Escuela);

        }
        static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.DibujarLinea("cursos escuela".Length);
            WriteLine("Cursos escuela");
            Printer.DibujarLinea("cursos escuela".Length);
            if (escuela?.Cursoz != null)
            {
                foreach (var curso in escuela.Cursoz)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }
        }
    }
}
