using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServis.Data
{
   public partial class Vozila
    {
       public override string ToString()
       {
           return Naziv + "-" + Godiste + "-" + VrstaMotora + "-" + Cijena;
       }

    }
}
