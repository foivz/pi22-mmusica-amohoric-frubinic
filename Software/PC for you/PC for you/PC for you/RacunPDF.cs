﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_for_you
{
    public class RacunPDF
    {
        private List<komponenta> listaKomponenata;
        private List<maticna> listaMaticna;
        private static List<KomponentaZaKosaricu> listaKomponenataZaKosaricu = new List<KomponentaZaKosaricu>();
        PI2233_DBEntities context = new PI2233_DBEntities();
        public int IdNarudzba { get; set; }
        public string Korime { get; set; }
        public RacunPDF(int idNarudzba, string korime)
        {
            IdNarudzba = idNarudzba;
            Korime = korime;
            GenerirajRacunPDF();
        }

        private void GenerirajRacunPDF()
        {
            listaKomponenata = VratiListuKomponenta();
            listaMaticna = VratiListuMaticna();
            KomponentaZaKosaricu.NapuniListuKomponenataKosarice(listaKomponenata, listaMaticna, listaKomponenataZaKosaricu);

            string deviceInfo = "";
            string[] streamIds;
            Warning[] warnings;
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;

            ReportViewer viewer = new ReportViewer();
            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = "../../Reports/Racun.rdlc";
     
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DsNarucujeKorisnika", NarucujeKorisnik()));
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DsKorisnik",VratiKorisnika()));
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DsNarudzba",VratiNarudzbu()));
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DsNaruceneKomponente", listaKomponenataZaKosaricu));
            viewer.RefreshReport();

            try
            {
                var bytes = viewer.LocalReport.Render("PDF", deviceInfo, out mimeType, out encoding, out extension, out streamIds, out warnings);
                string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName; 
                string fileName = Path.Combine(path, "PCforYouRacun.pdf");
                File.WriteAllBytes(fileName, bytes);
            }
            catch { }  
        }

        private List<narucuje> NarucujeKorisnik() 
        {
            var query = from nar in context.narucuje
                        where nar.IdNarudzbe == IdNarudzba
                        select nar;
            return query.ToList();
        }
        private List<korisnik> VratiKorisnika()
        {
            var query = from korisnik in context.korisnik
                        where korisnik.UserName == Korime
                        select korisnik;
            return query.ToList();
        }
        private List<komponenta> VratiListuKomponenta()
        {
            var query = from narudzba in context.narucuje
                        where narudzba.IdNarudzbe == IdNarudzba && narudzba.komponenta!=null
                        select narudzba.komponenta;

            return query.ToList();
        }
        private List<narudzba> VratiNarudzbu()
        {
            var query = from n in context.narucuje
                        where n.IdNarudzbe == IdNarudzba
                        select n.narudzba;

            return query.ToList();
        }
        private List<maticna> VratiListuMaticna()
        {
            var query = from sven in context.narucuje
                        where sven.IdNarudzbe == IdNarudzba && sven.maticna != null
                        select sven.maticna;

            return query.ToList();
        }
        

    }

}