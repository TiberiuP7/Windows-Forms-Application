using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariuriSportive.Model
{
    public class Pariuri
    {
        public long Id { get; set; }
        public string Selectie { get; set; }
        public DateTime OraPariu { get; set; }
        public decimal SumaPariata { get; set; }
        public decimal Cota { get; set; }
        public string Meci { get; set; } // Meciul asociat cu pariul
        public decimal PosibilCastig { get; set; }

        public Pariuri(long id, string selectie, DateTime oraPariu, decimal sumaPariata, decimal cota, string meci)
        {
            Id = id;
            Selectie = selectie;
            OraPariu = oraPariu;
            SumaPariata = sumaPariata;
            Cota = cota;
            Meci = meci;
            PosibilCastig = SumaPariata * Cota;
        }

        public Pariuri(string selectie, DateTime oraPariu, decimal sumaPariata, decimal cota, string meci)
        {
            Selectie = selectie;
            OraPariu = oraPariu;
            SumaPariata = sumaPariata;
            Cota = cota;
            Meci = meci;
            PosibilCastig = SumaPariata * Cota;
        }

        public Pariuri()
        {
            // Constructor gol pentru initializare fara parametri
        }
    }
}
