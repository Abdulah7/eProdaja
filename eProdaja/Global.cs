using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Resources;

namespace eProdaja
{
    public class Global

    {
        public static eProdajaServis.Data.Korisnici prijavakorisnika { get; set; }
        public static string GetString(string key)
        {
            ResourceManager rm = new ResourceManager("eProdaja.Poruke", Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }
    }
}
