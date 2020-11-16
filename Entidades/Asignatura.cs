using System;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string Nombre { get; set; }
        public string UniqueId { get; private set; }
        public Asignatura() => UniqueId = Guid.NewGuid().ToString();
    }
}