using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Bungalow
    {
        public double Prix { get; set; }
        public string Description { get; set; }
        public int id { get; set; }
        public int NombreChambre { get; set; }
        public ICollection<Option> options { get; set; }
        public ICollection<Reservation> reservations { get; set; }
    }
}
