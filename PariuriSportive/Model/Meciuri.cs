using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariuriSportive.Model
{
    public enum StareMeciEnum
    {
        InDesfasurare,
        Finalizat,
        Anulat
    }
    public class Meciuri
    {
        public long Id { get; set; }
        public string NumeEchipa1 { get; set; }
        public string NumeEchipa2 { get; set; }

        #region DataMeciului
        private DateTime DataMeciului;
        
        public DateTime dataMeciului
        {
            get { return DataMeciului; }

            set
            {
                if (value.Date < DateTime.Now.Date)
                {
                    throw new InvalidKickoffTimeException(value);
                }
                DataMeciului = value;
            }
        }
        #endregion

        public string Locatie { get; set; }
        public string Competitie { get; set; }
        public string StareMeci { get; set; } // In desfasurare, Finalizat, Anulat

        public Meciuri(long id, string numeEchipa1, string numeEchipa2, DateTime dataMeciului, string locatie, string competitie, string stareMeci)
        {
            Id = id;
            NumeEchipa1 = numeEchipa1;
            NumeEchipa2 = numeEchipa2;
            DataMeciului = dataMeciului; // Use field to skip validation when reloading from database
            Locatie = locatie;
            Competitie = competitie;
            StareMeci = stareMeci;
        }

        public Meciuri(string numeEchipa1, string numeEchipa2, DateTime dataMeciului, string locatie, string competitie, string stareMeci)
        {
            NumeEchipa1 = numeEchipa1;
            NumeEchipa2 = numeEchipa2;
            this.dataMeciului = dataMeciului;
            Locatie = locatie;
            Competitie = competitie;
            StareMeci = stareMeci;
        }

        public Meciuri()
        {
            // Constructor gol pentru initializare fara parametri
        }
        public override string ToString()
        {
            return $"{NumeEchipa1} - {NumeEchipa2}";
        }
    }
}
