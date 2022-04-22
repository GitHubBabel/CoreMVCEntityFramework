using System.ComponentModel.DataAnnotations;

namespace CoreMVCEntityFramework.Models
{
    public class AmigosCLS
    {
        public int ID { get; set; }

        [Required]
        [Display(Name ="Nombre de Amigo")]
        public string NOMBRE { get; set; }

        [Display(Name = "Edad de Amigo")]
        public int EDAD { get; set; }
    }
}
