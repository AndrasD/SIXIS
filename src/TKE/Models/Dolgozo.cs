using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TKE.Models
{
    public class Dolgozo
    {
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int DolgozoID { get; set; }

        [Required(ErrorMessage = "Név megadása kötelező!")]
        [Display(Name = "Dolgozó név")]
        [MaxLength(45)]
        public string DolgozoNev { get; set; }

        [Required(ErrorMessage = "Azonosító megadása kötelező!")]
        [Display(Name = "Azonosító")]
        [MaxLength(45)]
        public string Azonosito { get; set; }

        [Required(ErrorMessage = "Jelszó megadása kötelező!")]
        [Display(Name = "Jelszó")]
        [DataType(DataType.Password)]
        [ConcurrencyCheck, MaxLength(45, ErrorMessage = "A jelszónak 6 és 45 karakter között kell lennie"), MinLength(6)]
        public string Jelszo { get; set; }

        [Required(ErrorMessage = "Jogultsági szint megadása kötelező!")]
        [Display(Name = "Jogosultság")]
        [MaxLength(1)]
        public string Szint { get; set; }

        [Required]
        [Display(Name = "Óradíj hétközben")]
        [DefaultValue(0)]
        public int OraHK { get; set; }

        [Required]
        [Display(Name = "Óradíj hétvégén")]
        [DefaultValue(0)]
        public int OraHV { get; set; }

        [Required]
        [Display(Name = "Kilométer szorzó")]
        [DefaultValue(0)]
        public int KmSzorzo { get; set; }

    }
}
