using System;
using Domain;

namespace Domain
{
    public class Usuario
    {
        public byte Id { get; set; }

        public string Rol { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string FirstLastname { get; set; }

        public string SecondLastname { get; set; }

        public string Pais { get; set; }

        public string Afiliacion { get; set; }

        public string NivelFormacion { get; set; }

        public byte IdEspecialidad { get; set; }

        public Especialidad Especialidad { get; set; }

        public ICollection<Telefono>? Telefonos { get; set; }

        public Usuario( byte Id, string Rol, string Email, string PasswordHash, string PasswordSalt,
                        string FirstName, string SecondName, string FirstLastname, string SecondLastname,
                        string Pais, string Afiliacion, string NivelFormacion, byte IdEspecialidad){
            this.Id=Id;
            this.Rol=Rol;
            this.Email=Email;
            this.PasswordHash=PasswordHash;
            this.PasswordSalt=PasswordSalt;
            this.FirstName=FirstName;
            this.SecondName=SecondName;
            this.FirstLastname=FirstLastname;
            this.SecondLastname=SecondLastname;
            this.Pais=Pais;
            this.Afiliacion=Afiliacion;
            this.NivelFormacion=NivelFormacion;
            this.IdEspecialidad =IdEspecialidad;
        }

        public Usuario(){
            
        }
    }
}
