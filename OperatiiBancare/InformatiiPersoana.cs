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
        /// <summary>
        ///  Constructor fara parametrii
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

        /// <summary>
        /// Scurta descriere a persoanei
        /// </summary>
        /// <returns></returns>
        public string DescriereScurta()
        {
            return "Persoana are numele: " + Nume +" "+ Prenume + " si numarul de telefon: " + TelefonMobil;
        }

        public string CandAFostAdaugat()
        {
            return DataAdaugarii.ToString();
        }
    }
}
