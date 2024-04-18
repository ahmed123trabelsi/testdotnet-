using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Locataire
    {
        [Key]
        public string CIN { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Tel { get; set; }
        public ICollection<Reservation> reservations { get; set; }

    }
}
