using System;

namespace Domain
{
    public class Telefono
    {
        public byte IdUsuario { get; set; }

        public string NumeroTelefonico { get; set; }

        public Telefono(byte IdUsuario, string NumeroTelefonico){
            this.IdUsuario = IdUsuario;
            this.NumeroTelefonico = NumeroTelefonico;
        }

        public Telefono(){
            
        }
    }
}
