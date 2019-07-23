using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kol.Models
{
    public class Car
    {
        [Key]
        [Required, MaxLength(150)]
        public int IdCar { get; set; }

        [Required(ErrorMessage = "Numer jest wymagane"), MaxLength(150, ErrorMessage = "Numer może mieć maks 150 znaków"), Display(Name = "Numer Rejestracyjny")]
        public string RegisterNumber { get; set; }

        [Required(ErrorMessage = "Model jest wymagane"), MaxLength(150, ErrorMessage = "Model może mieć maks 150 znaków"), Display(Name = "Model")]
        public string Model { get; set; }

        public ICollection<Rent> Rents { get; set; }
    }
}
