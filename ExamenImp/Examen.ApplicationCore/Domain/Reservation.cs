using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime DateDebut { get; set; }
        [Required(ErrorMessage = "nombre est obligatoire.")]
        public int NombreJour { get; set;}
        [Required(ErrorMessage = "saison est obligatoire."),Range(1,4)]
        public int saison { get; set; }
        public string LocataireFK { get; set; }
        [ForeignKey("LocataireFK")]
        public Locataire Locataire { get; set; }
    
        public int BungalowFK { get; set; }




        [ForeignKey("BungalowFK")]
        public Bungalow bungalow { get; set; }

    }
}
