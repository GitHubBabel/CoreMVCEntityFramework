using System.ComponentModel.DataAnnotations;

namespace CoreMVCEntityFramework.Models
{
    public class UsuarioCLS
    {
        //LLAVE PRIMARIA AUTOINCREMENTAL
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre de Usuario")]
        public string NOMBRE { get; set; }
        [Required(ErrorMessage = "Los apellidos son obligatorio")]

        [Display(Name = "Apellidos")]
        public string APELLIDOS { get; set; }

        [Display(Name = "Teléfono")]
        //[Range(7, 8, ErrorMessage ="El teléfono debe ser de 8 numeros")]
        public string TELEFONO { get; set; }

        [Display(Name = "Celular")]
        //[Range(7, 8, ErrorMessage = "El celular debe ser de 8 numeros")]
        public string CELULAR { get; set; }

        [Display(Name = "Correo Electronico")]
        [EmailAddress (ErrorMessage ="Debe tener un formato tipo Email")]
        public string Email { get; set; }

        ////PROPIEDADES ADICIONALES
        //public string Mensaje { get; set; }

    }
}
