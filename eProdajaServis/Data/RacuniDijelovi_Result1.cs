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
    
    public partial class RacuniDijelovi_Result1
    {
        public int RacunID { get; set; }
        public int KorisnikID { get; set; }
        public string Opis { get; set; }
        public double Cijena { get; set; }
        public string Komentar { get; set; }
        public double PDV { get; set; }
        public double Ukupno { get; set; }
        public System.DateTime DatumFakture { get; set; }
        public Nullable<System.DateTime> DatumIsporuke { get; set; }
        public string NacinIsporuke { get; set; }
        public int PlacanjeID { get; set; }
        public int KupacID { get; set; }
        public Nullable<int> DijeloviID { get; set; }
        public Nullable<int> temp { get; set; }
        public Nullable<int> Prodato { get; set; }
        public Nullable<double> Popust { get; set; }
        public Nullable<double> Rabat { get; set; }
    }
}
