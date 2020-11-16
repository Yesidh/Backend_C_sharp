using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
    
         string nombre; 
         public string Nombre
         {
             get { return "Copia: "+ nombre; }
             set { nombre = value.ToUpper(); }
         }

         public int anhoCreacion { get; set; }
         public string Pais { get; set; }
         public string Ciudad { get; set; }
         public Escuela(string nombre, int anho, TiposEscuela tipos,
                        string pais = "", string ciudad = "") : base ()
                        {
                            (Nombre, anhoCreacion) = (nombre, anho);
                            Pais = pais;
                            Ciudad = ciudad;
                        } 

        public TiposEscuela TiposEscuela{ get; set; }
        public List<Cursos> Cursoz { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TiposEscuela} \n Pais: {Pais}, Ciudad: {Ciudad} ";
        }
    }
}