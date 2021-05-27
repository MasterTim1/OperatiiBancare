using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatiiBancare
{
    class InformatiiPersoana
    {   /// <summary>
        ///     Informatii persoana
        /// </summary>
        public string Nume;
        public string Prenume;
        public string NumarulCardului;
        public string DataExpirarii;
        public string CCV;

        public string TelefonMobil;
        public string Email;
        
        private DateTime DataAdaugarii;
        private string v;

        /// <summary>
        ///  Constructor fara parametrii (implicit)
        /// </summary>
        public InformatiiPersoana()
        {
            Nume = "Fara nume:";

            TelefonMobil = "-";
            Email = "-";

            DataAdaugarii = DateTime.Now;
        }
       
        /// <summary>
        /// Constructor cu parametrii pentru nume si telefon
        /// </summary>
        /// <param name="n">Numele initial al persoanei</param>
        /// <param prenume ="p">Prenumele initial al persoanei</param>
        /// <param name="t">Telefonul initial al persoanei</param>
        public InformatiiPersoana(string n,string p,string t)
        {
            Nume = n;
            Prenume = p;
            TelefonMobil = t;


        }
        public InformatiiPersoana(string info)
        {
            string[] vdate = info.Split(',');

            Nume = vdate[0];
            Prenume = vdate[1];
          NumarulCardului = vdate[2];
        }


        public bool CompararePersoana(InformatiiPersoana p)
        {
            if (String.Compare(this.Nume, p.Nume) == 0)
                if (String.Compare(this.Prenume, p.Prenume) == 0)
                    if (String.Compare(this.NumarulCardului, p.NumarulCardului) == 0)
                        return true;
            return false;

        }
       
        /// <summary>
        /// Scurta descriere a persoanei
        /// </summary>
        /// <returns></returns>
        public string ConversieLaSir()
        {
            return  Nume + Prenume +  NumarulCardului;
        }

        public string CandAFostAdaugat()
        {
            return DataAdaugarii.ToString();
        }
    }
}
