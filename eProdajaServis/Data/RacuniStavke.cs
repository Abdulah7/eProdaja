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
    
    public partial class RacuniStavke
    {
        public int StavkaID { get; set; }
        public Nullable<int> DijeloviID { get; set; }
        public Nullable<int> VoziloID { get; set; }
        public Nullable<int> RacunID { get; set; }
        public int Kolicina { get; set; }
        public Nullable<double> Popust { get; set; }
        public Nullable<double> Rabat { get; set; }
    
        public virtual Dijelovi Dijelovi { get; set; }
        public virtual Racuni Racuni { get; set; }
        public virtual Vozila Vozila { get; set; }
    }
}
