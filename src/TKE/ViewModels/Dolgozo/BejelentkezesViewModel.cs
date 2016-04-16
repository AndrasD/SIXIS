using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TKE.ViewModels.Dolgozo
{
    public class BejelentkezesViewModel
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Azonosito { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Jelszo { get; set; }
    }
}
