using System;

namespace OperatiiBancare
{
    class Program
    {
        static void Main(string[] args)
        {
            InformatiiPersoana persoana = new InformatiiPersoana("Grigoriciuc","Timotei ", "074812...");
            

            string descriere = persoana.DescriereScurta();
            Console.WriteLine(descriere);
            Console.ReadKey();

            
        }
    }
}
