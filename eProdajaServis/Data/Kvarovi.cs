//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eProdajaServis.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kvarovi
    {
        public int KvarID { get; set; }
        public string Opis { get; set; }
        public int KupacID { get; set; }
    
        public virtual Kupci Kupci { get; set; }
    }
}
