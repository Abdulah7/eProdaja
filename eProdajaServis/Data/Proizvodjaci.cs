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
    
    public partial class Proizvodjaci
    {
        public Proizvodjaci()
        {
            this.Dijelovi = new HashSet<Dijelovi>();
            this.Modeli = new HashSet<Modeli>();
        }
    
        public int ProizvodjacID { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<Dijelovi> Dijelovi { get; set; }
        public virtual ICollection<Modeli> Modeli { get; set; }
    }
}