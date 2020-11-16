using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Cursos
    {
        public string Nombre { get; set; }
        public string UniqueId { get; private set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Cursos() => UniqueId = Guid.NewGuid().ToString();
        
    }
}