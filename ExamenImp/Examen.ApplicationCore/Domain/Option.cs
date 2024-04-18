using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Option
    {
        Commodite commodite = Commodite.LitEnfant;
        public int OptionId { get; set; }
        public double PrixOption { get; set; }
        public Bungalow bungalow { get; set; }
    }
}
