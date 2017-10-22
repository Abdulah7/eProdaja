using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace eProdajaServis.Data
{
     
    
    public class Servis
    {
        
        
        public static int TotalRows;
     
        public static void insertkorisnik(Korisnici  s)
        {
            try
            {
                Connection.dm.insertKorisnik(s.Ime,s.Prezime, s.Adresa, s.Telefon, s.Email, s.Status, s.LozinkaHash, s.SalonID,s.LozinkaSalt);
            }
            catch (EntityException v)
            {
                Util.PomocnaKlasa.Handler(v);

            }


     


           
        }
   
      
        public static List<Korisnici> getAllSERVIS()
        {

            List<Korisnici> s = Connection.dm.getAllServis().ToList();
            Korisnici d = new Korisnici();

            d.KorisnikID = 0;
            d.Ime = "";
            s.Insert(0, d);
            return s;
        
        }
        
        public static Korisnici SelectImeKorisnika(string ime, string lozinka)
        {
            Korisnici s = Connection.dm.selectKorisnickoIme(ime).FirstOrDefault();


              if (s!= null)
              {

                  if (Util.UIHelper.GenerateHash(lozinka, s.LozinkaSalt) == s.LozinkaHash)
                  {

              
                      return s;
                  }
                  

              }
              return null;
    
 
           
         
        }
        public static List<esp_select_by_Name_Result1> esp_SelektBy_Name(string imeKorisnika)
        {
            return Connection.dm.esp_select_by_Name(imeKorisnika).ToList();
        }
        public static void updateStatus(int servisId, bool status)
        {
             Connection.dm.esp_update_status(servisId, status);
        }
        public static Korisnici seletBYId(int servisId)
        {
            return Connection.dm.esp_ServisSelectID(servisId).First();
        }
        public static void UpdateServis(Korisnici s)
          {
              Connection.dm.Servis_Update(s.KorisnikID, s.Ime,s.Prezime, s.Adresa, s.Telefon, s.Email, s.Status, s.LozinkaHash, s.SalonID, s.LozinkaSalt);
          }
        public static void ResetLozninka(Korisnici s)
       {
           Connection.dm.Servis_IzmjenaPassworda(s.KorisnikID, s.LozinkaSalt, s.LozinkaHash);
       }
        public static List<Modeli>GetModel()
         {
             List<Modeli> m = Connection.dm.Modeli.OrderBy(x => x.Naziv).ToList();

             Modeli b = new Modeli();
             b.ModelID = 0;
             b.Naziv = "";

             m.Insert(0, b);
             return m;

         }
        public static List<Korisnici> GetServis()
        {
            List<Korisnici> temp = Connection.dm.SelectServis().ToList();

            Korisnici b = new Korisnici();
            b.KorisnikID = 0;
            b.Ime = "";

            temp.Insert(0, b);
            return temp;


        }
        public static List<Vozila>getVozilaAll(int m)
        {
            return Connection.dm.SelectIDAuto(m).ToList();
        }
        public static void insertVOZILA(Vozila v)
        {
            Connection.dm.insertVozilo(v.ModelID, v.Naziv, v.Boja, v.Godiste, v.VrstaMotora, v.EmisijaCO2, v.Slika, v.SlikaThumg,v.Cijena,v.Oprema,v.SnagaMotora,v.BrojSasije,v.ZapreminaMotora,v.ZapreminaGepeka,v.Duzina,v.Tezina,v.Klima,v.BrojSjedista,v.Pogon,v.BrojVrata,v.OpisSigurnost,v.Mijenjac,v.Potrosnja,v.ObrtniMoment,v.Sirina,v.Ubrzanje,v.MaksimalnaBrzina,v.Kolicina);
        }
        public static List<Modeli> getModelWeb()
        {
            List<Modeli> temp = Connection.dm.Modeli.OrderBy(x => x.Naziv).ToList();
            Modeli d = new Modeli();
            d.ModelID = 0;
            d.Naziv = "";

            temp.Insert(0, d);
            return temp;
        }

       
        public static Vozila getVoziloID(int v)
        {

            return Connection.dm.GetVoziloID(v).FirstOrDefault();
        }
        public static void KupciInsert(Kupci k)
        {

            Connection.dm.insertKupac(k.Ime, k.Prezime, k.Email,k.Telefon,k.Adresa,k.Lozinka);
        }

       
       

       
        public static List<RacunSelectByDatum_Result3> SelectRacunByDatum(DateTime d,DateTime dat)
        {
            return Connection.dm.RacunSelectByDatum(d,dat).ToList();
        }
        public static List<Dijelovi> getDetails()
        {
            List<Dijelovi> temp = Connection.dm.Dijelovi.OrderBy(x => x.Naziv).ToList();
            Dijelovi d = new Dijelovi();
            d.DioID = 0;
            d.Naziv= "";

            temp.Insert(0, d);

            return temp;
        }
        public static List<GEtNazivDijelovaALl_Result6> getALLDijelovi(string dd)
        {
             return    Connection.dm.GEtNazivDijelovaALl(dd).ToList();

        

        }
        public static List<Korisnici> GETSERVISALL()
        {
            List<Korisnici> temp = Connection.dm.Korisnici.OrderBy(x => x.Ime).ToList();
            Korisnici d = new Korisnici();
            d.KorisnikID = 0;
            d.Ime = "";

            temp.Insert(0, d);

            return temp;
        }
        public static Dijelovi getdijelovI (int d)
        {
            return Connection.dm.GETDijeloviID(d).FirstOrDefault();
            
        }
       
        
        public static List<Dijelovi> GetDijelove()
        {
            List<Dijelovi> temp = Connection.dm.Dijelovi.OrderBy(x => x.Naziv).ToList();
            Dijelovi d = new Dijelovi();
            d.DioID = 0;
            d.Naziv = "";

            temp.Insert(0, d);

            return temp;
        }

        public static void RacunInsert(Racuni r)
        {
            Connection.dm.InsertRacun(r.KorisnikID,  r.Cijena, r.Komentar, r.PDV, r.Ukupno, r.NacinIsporuke, r.DatumFakture, r.DatumIsporuke,r.PlacanjeID,r.KupacID);
        }
        public static List<Proizvodjaci> GetProizvodjac()
        {
            List<Proizvodjaci> temp = Connection.dm.Proizvodjaci.OrderBy(x => x.Naziv).ToList();
            Proizvodjaci d = new Proizvodjaci();
            d.ProizvodjacID = 0;
            d.Naziv = "";

            temp.Insert(0, d);

            return temp;
        }
        public static void ModelInsert(Modeli m)
        {
            Connection.dm.InsertModel(m.ProizvodjacID, m.Naziv, m.VrstaModela);
        }
        public static void ProizovdjacInsert(Proizvodjaci p)
        {
            Connection.dm.InsertProizvodjac(p.Naziv, p.Adresa, p.Telefon, p.Email);
        }

        public static List<PretragaAuta_Result2> PretragaAUTA(string naziv)
        {
            return Connection.dm.PretragaAuta(naziv).ToList();

        }
        public static void BrisiAuto(int auto)
        {
            Connection.dm.BrisanjeAuta(auto);
        }
       
        
        public static void BrisiDijelove(int dioID)
        {
            Connection.dm.DijeloviDelete(dioID);
        }
       
        public static List<Dijelovi> getDijeloveNaziv(string naziv,string s)
        {
            return Connection.dm.DijeloviSearch(naziv,s).ToList();
        }
       
        public static List<Kupci> getKupciALL(string ime,string p)
        {
            return Connection.dm.SearchKupac(ime,p).ToList();
        }
        public static void KupacDelete(int kupacID)
        {
            Connection.dm.DeleteKupac(kupacID);
        }
        public static void DijeloviInsert(Dijelovi d)
        {
            Connection.dm.InsertDijelove(d.Naziv, d.Zalihe, d.Cijena,d.Sifra,d.ProizvodjacID,d.AutaProizvedena,d.Opis);
        }
        public static List<ALLCars_Result1> GetCarAll(string naziv)
        {
            return Connection.dm.ALLCars(naziv).ToList();

        }
       
      
        public static Kupci KorisnikKupacIme(string ime)
        {
            return Connection.dm.selectKupacKorisinickoIme(ime).FirstOrDefault();
        }
     
        public static Kupci KupacID(int k)
        {
            return Connection.dm.getIDKupac(k).FirstOrDefault();
        }
      
      
       
        public static List<NaciniPlacanja> getPlacananje()
        {
            List<NaciniPlacanja> temp= Connection.dm.NaciniPlacanja.OrderBy(x => x.Naziv).ToList();
          
            NaciniPlacanja d = new NaciniPlacanja();
            d.PlacanjeID = 0;
            d.Naziv = "";

            temp.Insert(0, d);

            return temp;
        }
        public static List<Dijelovi> getDijeloviGRid()
        {
                return Connection.dm.Dijelovi.OrderBy(x=> x.Naziv).ToList();
            

        }
        public static List<Kupci> getKupacIDNew(string k)
        {
            return Connection.dm.GetKupacIME(k).ToList();
        }
        public static List<Kupci> getKupciIme()
        {
           List<Kupci> temp=  Connection.dm.Kupci.OrderBy(x => x.Ime).ToList();

            Kupci d = new Kupci();
            d.KupacID = 0;
            d.Ime = "Dodaj kupca";

            temp.Insert(0, d);

            return temp;

        }
        public static List<GEtALLAuta_Result6> getAllVozila()
        {
            return Connection.dm.GEtALLAuta().ToList();
        }
        public static List<Kupci> KupciGET()
        {
           return  Connection.dm.Kupci.OrderBy(x => x.Ime).ToList();

        }
        public static List<Dijelovi> DijeloviGET()
        {
            return Connection.dm.Dijelovi.OrderBy(x => x.Naziv).ToList();
        }
       

       
       
      
        public static List<Vozila> getvozilaAll()
        {
            List<Vozila> temp = Connection.dm.Vozila.OrderBy(x => x.Naziv).ToList();

            Vozila d = new Vozila();
            d.VoziloID = 0;
            d.Naziv = "";

            temp.Insert(0, d);

            return temp;
        }
        public static List<GetInfo_Result2> getInfo()
        {
            return Connection.dm.GetInfo().ToList();
        }
        public static List<GetInfoUkupno_Result> getInfoUkupno()
        {
            return Connection.dm.GetInfoUkupno().ToList();
        }
        public static List<GETALLDijelove_Result> DijeloviGEt()
        {
            return Connection.dm.GETALLDijelove().ToList();
        }
        public static List<GETProdajaInfo_Result> getinfoProdaja()
        {
            return Connection.dm.GETProdajaInfo().ToList();
        }
        public static  void DijeloviUpdate(int d, int naziv )
        {

            Connection.dm.updateDijelovi(d, naziv);
        }
     
       public static List<getZalihe_Result> ZaliheGet()
       {
           return Connection.dm.getZalihe().ToList();
       }
       public static List<GEtNazivAutaALL_Result2> getAutaAll(string a)
       {
           return Connection.dm.GEtNazivAutaALL(a).ToList();
       }
       

        public static void updataModelKolicina(int n,int k)
        {

            Connection.dm.updateAuta(n, k);
        }

        public static List<getZaliheAuta_Result> GetZaliheAuta()
        {
            return Connection.dm.getZaliheAuta().ToList();
        }
        public static List<getAllProdajaAuta_Result>GEtProdajaAuta()
        {

            return Connection.dm.getAllProdajaAuta().ToList();
        }
        public static List<ProdajaAutaInfo_Result1>getInfoAutaResult()
        {
            return Connection.dm.ProdajaAutaInfo().ToList();
        }

        public static List<SalonAuta> getSalon()
        {
        List<SalonAuta> temp = Connection.dm.SalonAuta.OrderBy(x => x.Naziv).ToList();
          

            return temp;
        }
        public static List<getRacun1_Result> getracun()
        {
            return Connection.dm.getRacun1().ToList();
        }
        public static List<ProdajaAutaInfoU_Result2>getProdajaAuta()
        {
            return Connection.dm.ProdajaAutaInfoU().ToList();
        }
        public static List<Proizvodjaci>GEtallPro()
        {
        List<Proizvodjaci> temp=  Connection.dm.Proizvodjaci.OrderBy(x => x.Naziv).ToList();

            Proizvodjaci d = new Proizvodjaci();
            d.ProizvodjacID = 0;
            d.Naziv = "";

            temp.Insert(0, d);

            return temp;
        }
        public static List<DijeloviAllGet_Result> getDijlovIGEt()
        {
            return Connection.dm.DijeloviAllGet().ToList();
        }
        public static List<Kupci>KupciGEt()
        {

            List<Kupci> temp = Connection.dm.Kupci.OrderBy(x => x.Ime).ToList();
            Kupci d = new Kupci();
            d.KupacID = 0;
            d.Ime = "";

            temp.Insert(0, d);

            return temp;
         
        }
        public static   List<searchModel_Result3> getModelSearch(string m,string k)
        {
            return Connection.dm.searchModel(m,k).ToList();
        }
        public static List<RacuniDijelovi_Result2> getRacunDijelvi()
        {
            return Connection.dm.RacuniDijelovi().ToList();
        }
        public static List<RacuniAuta_Result5> getRacunAuta()
        {
            return Connection.dm.RacuniAuta().ToList();
        }
        public static void RacunStavkeinsert(RacuniStavke r)
        {
            Connection.dm.InsertRacunStavke(r.DijeloviID, r.VoziloID, r.RacunID, r.Kolicina, r.Popust, r.Rabat);
        }
        public static List<Racuni> Racunget()
        {
            return Connection.dm.RacunGET().ToList();
        }
        public static GetIDKupacRacun_Result3 RacunID(int k)
        {
            return Connection.dm.GetIDKupacRacun(k).First();
        }
     
        public static List<GetAutaRacunStavke_Result> getReportDijelovi(int id)
        {
            return Connection.dm.GetAutaRacunStavke(id).ToList();
        }
        public static List<AutaALLGET_Result1> GEEEETAuta()
        {
            return Connection.dm.AutaALLGET().ToList();
        }
        public static List<Vozila> PretragNNNNNNazivAuta( string a,string s)
        {
            return Connection.dm.PretragaPoNazivuAuta(a,s).ToList();
        }
        public static void korisnikDelete(int k)
        {
            Connection.dm.deleteKorisnik(k);

        }
        public static void UpdataStatusTr(int  k,bool l)
        {
            Connection.dm.update_statusTrue(k,l);

        }
        public static void AutaIzmjena(Vozila v)
        {
            Connection.dm.IzmjenaAuta(v.VoziloID,v.ModelID, v.Naziv, v.Boja, v.Godiste, v.VrstaMotora, v.EmisijaCO2, v.Slika, v.SlikaThumg, v.Cijena, v.Oprema, v.SnagaMotora, v.BrojSasije, v.ZapreminaMotora, v.ZapreminaGepeka, v.Duzina, v.Tezina, v.Klima, v.BrojSjedista, v.Pogon, v.BrojVrata, v.OpisSigurnost, v.Mijenjac, v.Potrosnja, v.ObrtniMoment, v.Sirina, v.Ubrzanje, v.MaksimalnaBrzina,v.Kolicina);
        }
        public static void  DeleteAuta(int v)
        {
            Connection.dm.AutaDelete(v);
        }
        public static List<Kupci>KupciPretraaga(string a,string b)
        {
            return Connection.dm.PretragaKupaca(a, b).ToList();
        }
        public static Racuni GetRAcunID(int g)
        {
          return  Connection.dm.getRAcunID(g).FirstOrDefault();
        }
        public static List<Vozila>IDAuta(int a)
        {
            return Connection.dm.AutaID(a).ToList();
        }
        public static void UpDijelova(Dijelovi d)
        {
            Connection.dm.DijeloviUpdate(d.DioID, d.Naziv, d.Zalihe, d.Cijena, d.Sifra, d.ProizvodjacID, d.AutaProizvedena, d.Opis);
        }
        public static void KupacUp(Kupci k)
        {
            Connection.dm.UpdateKupca(k.KupacID, k.Ime, k.Prezime, k.Email, k.Telefon, k.Adresa,k.Lozinka);
        }
        public static List<Dijelovi> Dijelovigg(int d)
        {
            return Connection.dm.DijelovigetAll(d).ToList();

        }
        public static void UpdateProizvodjac(Proizvodjaci p)
        {
            Connection.dm.ProizvodjaciUpdate(p.ProizvodjacID, p.Naziv, p.Adresa, p.Telefon, p.Email);
        }
        public static Proizvodjaci ProizvodjacID(int p)
        {
           return   Connection.dm.IDProizvodjac(p).FirstOrDefault();
        }
        public static List<GetProzvodjac_Result1> GEtAllPro()
        {
            return Connection.dm.GetProzvodjac().ToList();
        }
        public static void ProizvodjacDelete(int p)
        {
            Connection.dm.DeleteProizvodjac(p);
        }
        public static void UModel(Modeli m)
        {
            Connection.dm.UpdateModel(m.ModelID, m.ProizvodjacID, m.Naziv, m.VrstaModela);
        }

        public static Modeli  ModeliID (int m)
        {
           return Connection.dm.GEtIDModel(m).FirstOrDefault();
        }
        public static List<Modeli>ModeliGetAll( string n,string v)
        {
            return Connection.dm.SelectALLModele(n,v).ToList();
        }
        public static List<GetModele_Result1> ModeliAll()
        {
            return Connection.dm.GetModele().ToList();
        }
        public static void ModelDelete(int p)
        {
            Connection.dm.DeleteModel(p);
        }
        public static List<GetDijeloviRacunStavke_Result1> getDijeloviStavke(int ff)
        {
            return Connection.dm.GetDijeloviRacunStavke(ff).ToList();

        }
        public static List<getUkupno_Result2>getAutaDijeloviUkupno(int k)
        {
            return Connection.dm.getUkupno(k).ToList();

        }
        public static List<GetDijeloviStavke_Result>StavKeDijeloviResult(int r)
        {
            return Connection.dm.GetDijeloviStavke(r).ToList();
        }

        public static List<GetAutaStavke_Result> StavkeAutaResult(int r)
        {
            return Connection.dm.GetAutaStavke(r).ToList();
        }
        public static List<KupciGEtAll_Result> Klient()
        {
            return Connection.dm.KupciGEtAll().ToList();
        }
    }



}
