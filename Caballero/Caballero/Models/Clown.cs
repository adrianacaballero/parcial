using System;
using System.ComponentModel.DataAnnotations;

namespace Caballero.Models
{
    public class Clown
    {
        public enum Lista
        {
            abejas,
            aviones,
            autos
        }
       
       
            [Key]
            public int ClownId { get; set; }

            [Required]
            [StringLength(24, MinimumLength = 2)]
            [Display(Description = "Nombre completo")]
            public string NickName { get; set; }

            [Required]
            public Lista Tricks { get; set; }

            [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
            ErrorMessage = "ingrese direccion correcta")]
            public string Email { get; set; }


            [Display(Description = "Cumpleaños")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime Birthdate { get; set; }

        }
    }