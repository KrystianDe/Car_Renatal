using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kol.Models
{
    public class Rent
    {
        [Key]
        public int IdRent { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany"), MaxLength(255, ErrorMessage = "Opis może mieć maksymalnie 255 znaków"), Display(Name = "Opis")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Klient jest wymagany"), MaxLength(255, ErrorMessage = "Klient może mieć maksymalnie 255 znaków"), Display(Name = "Klient")]
        public string Client { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        [Display(Name = "Samochód")]
        public int IdCar { get; set; }

        [ForeignKey("IdCar")]
        public Car Car { get; set; }
    }
}
