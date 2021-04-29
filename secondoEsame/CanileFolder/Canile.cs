using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace secondoEsame.CanileFolder
{
    public class Canile
    {
        [Key]
        public int Id_cane  {get; set;}

        [Required(ErrorMessage = "Devi scegliere un nome!")]
        public string Nome_cane { get; set; }

        [Required(ErrorMessage = "Devi selezionare la data di nascita!")]
        public DateTime Anno_nascita { get; set; }

        [Required(ErrorMessage = "Devi scegliere la razza!")]
        public string Razza { get; set; }

        [Required(ErrorMessage = "Devi scegliere il periodo!")]
        public bool Genere { get; set; }

        [Required(ErrorMessage = "Devi scegliere il periodo!")]
        public DateTime Data_addozione { get; set; }

        [Required(ErrorMessage = "Devi scegliere il periodo!")]
        public DateTime Data_acquisizione { get; set; }

        [Required(ErrorMessage = "Devi scegliere il periodo!")]
        public bool Sterilizzato { get; set; }

        [Required(ErrorMessage = "Devi scegliere il periodo!")]
        public DateTime Data_steril { get; set; }
    }
}
