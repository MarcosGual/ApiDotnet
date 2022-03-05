using System;

namespace Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Soltero { get; set; }

        public Persona()
        {
            Nombre = "";
            Apellido = "";
        }
    }
}