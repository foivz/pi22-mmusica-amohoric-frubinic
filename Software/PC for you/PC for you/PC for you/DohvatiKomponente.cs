using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_for_you
{
    public class DohvatiKomponente
    {
        public string Tip { get; set; }
        public DataGridView Dgv { get; set; }
        public DohvatiKomponente(string tip, DataGridView dgv)
        {
            Dgv = dgv;
            Tip = tip;
        }

        public void DohvatiZeljenuKomponentu() 
        {
            using (var context = new PI2233_DBEntities())
            {

                switch (Tip)
                {
                    case "Procesor":
                        {
                            var odabraneKomponente = (from procesor in context.komponenta
                                                      where procesor.Tip == Tip
                                                      select new
                                                      {
                                                          ID = procesor.IdKomponenta,
                                                          Naziv = procesor.Naziv,
                                                          Proizvodac = procesor.Proizvodac,
                                                          Potrosnja = procesor.Potrosnja,
                                                          Brzina = procesor.Brzina,
                                                          Socket = procesor.Socket,
                                                          Cijena = procesor.Cijena

                                                      }).ToList();
                            Dgv.DataSource = odabraneKomponente;
                            break;
                        }

                    case "Graficka":
                        {
                            var odabraneKomponente = (from graficka in context.komponenta
                                                      where graficka.Tip == Tip
                                                      select new
                                                      {
                                                          ID = graficka.IdKomponenta,
                                                          Naziv = graficka.Naziv,
                                                          Proizvodac = graficka.Proizvodac,
                                                          Potrosnja = graficka.Potrosnja,
                                                          Interface = graficka.Interface,
                                                          DuzinaGraficke = graficka.Duzina_graficke,
                                                          VRAM = graficka.Vram,
                                                          Cijena = graficka.Cijena

                                                      }).ToList();
                            Dgv.DataSource = odabraneKomponente;
                            break;
                        }
                    case "Napajanje": 
                        {
                            var odabraneKomponente = (from napajanje in context.komponenta
                                                      where napajanje.Tip == Tip
                                                      select new
                                                      {
                                                          ID = napajanje.IdKomponenta,
                                                          Naziv = napajanje.Naziv,
                                                          Proizvodac = napajanje.Proizvodac,
                                                          Kapacitet = napajanje.Kapacitet_napajanja,
                                                          Cijena = napajanje.Cijena


                                                      }).ToList();
                            Dgv.DataSource = odabraneKomponente;
                            break;
                        }
                    case "Maticna":
                        {
                            var query = (from m in context.maticna
                                        select m).ToList();
                            Dgv.DataSource = query;
                            break;
                        }
                    case "RAM":
                        {
                            var query = (from r in context.komponenta
                                        where r.Tip == Tip
                                        select new
                                        {
                                            ID = r.IdKomponenta,
                                            Naziv = r.Naziv,
                                            Proizvodac = r.Proizvodac,
                                            Potrosnja = r.Potrosnja,
                                            TipMemorije = r.Tip_memorije,
                                            Brzina = r.Brzina,
                                            Velicina = r.Velicina_memorije,
                                            Cijena = r.Cijena
                                        }).ToList();
                            Dgv.DataSource = query;
                            break;
                        }
                    case "Pohrana":
                        {
                            var query = (from p in context.komponenta
                                        where p.Tip == Tip
                                        select new
                                        {
                                            ID = p.IdKomponenta,
                                            Naziv = p.Naziv,
                                            Proizvodac = p.Proizvodac,
                                            Potrosnja = p.Potrosnja,
                                            Interface = p.Interface,
                                            PodrzavanaMaticna = p.Podrzavana_maticna,
                                            Cijena = p.Cijena
                                        }).ToList();
                            Dgv.DataSource = query;
                            break;
                        }
                    case "Kucista":
                        {
                            var query = (from k in context.komponenta
                                        where k.Tip == Tip
                                        select new
                                        {
                                            ID = k.IdKomponenta,
                                            Naziv = k.Naziv,
                                            Proizvodac = k.Proizvodac,
                                            Potrosnja = k.Potrosnja,
                                            MaxVelicinaGraficke = k.Maksimalna_duzina_graficke,
                                            PodrzavanaMaticna = k.Podrzavana_maticna,
                                            Cijena = k.Cijena
                                        }).ToList();
                            Dgv.DataSource = query;
                            break;
                        }
                      
                    default:
                        break;
                }

            }
        }
    }
}
