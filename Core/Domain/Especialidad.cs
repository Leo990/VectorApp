using System;

namespace Domain
{
    public class Especialidad
    {
        public byte Id { get; set; }

        public string Nombre { get; set; }
        public Especialidad(byte Id, string Nombre){
            this.Id = Id;
            this.Nombre = Nombre;
        }
    }
}
