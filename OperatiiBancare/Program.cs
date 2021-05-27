using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatiiBancare
{
    class Program
    {

        public static List<InformatiiPersoana> _listaPersoane;
        static void Main(string[] args)
        {
            Console.WriteLine("Nume \t\tPrenume\t\tNumarul Cardului");
            InformatiiPersoana var1 = new InformatiiPersoana("Grigoriciuc\t,Timotei\t,\t1234 5678 9102 3456");
            Console.WriteLine(var1.ConversieLaSir());
            

            InformatiiPersoana var2 = new InformatiiPersoana("Morariu\t,\tCristian\t,5432 3698 4102 3656");
            Console.WriteLine(var2.ConversieLaSir());


            InformatiiPersoana var3 = new InformatiiPersoana("Hapenciuc\t,Alexandru\t,5672 8648 4312 9656");
            Console.WriteLine(var3.ConversieLaSir());

            ///Verificare functie comparare
            if (var1.CompararePersoana(var2))
                Console.WriteLine("EXISTA DEJA IN SISTEM ACEASTA PERSOANA");


            /*
            _listaPersoane = new List<InformatiiPersoana>();


            
            InformatiiPersoana p = new InformatiiPersoana();

            Console.WriteLine(p.CandAFostAdaugat());
            
            p.Nume = "Keanu";
            p.Prenume = "Reeves";
            p.TelefonMobil = "035692156710";
            p.NumarulCardului = "1234 5678 9102 3456";
            p.DataExpirarii = "05/16";
            p.CCV = "456";
            

            _listaPersoane.Add(p);
            p = new InformatiiPersoana();

            p.Nume = "Jason";
            p.Prenume = "Statham";
            p.TelefonMobil = "0729251285";
            p.NumarulCardului = "5432 3698 4102 3656";
            p.DataExpirarii = "4/20";
            p.CCV = "652";

            _listaPersoane.Add(p);
            p = new InformatiiPersoana();
            p.Nume = "Jackie";
            p.Prenume = "Chan";
            p.TelefonMobil = "4029251285";
            p.NumarulCardului = "5672 8648 4312 9656";
            p.DataExpirarii = "2/12";
            p.CCV = "664";

            _listaPersoane.Add(p);
            


            
            //afisare persoane 

            Console.WriteLine("Nume \tPrenume\t Numarul Cardului");
            foreach (InformatiiPersoana pers in _listaPersoane)
            {
                
                Console.WriteLine(pers.Nume+"\t"+pers.Prenume +"\t "+ pers.NumarulCardului);
            }
            */




            Console.ReadKey();

            
        }
    }
}
