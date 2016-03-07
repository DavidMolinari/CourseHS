using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CoursePooHeritage
{
    public class Program
    {
        static void Main(string[] args)
        {
            var unCompetiteurTest = new Competiteur(22, "Michel", "String", 5, 7);
            unCompetiteurTest.NumeroCompetiteur = 21;
            Console.WriteLine(unCompetiteurTest.NomCompetiteur);

            Console.Read();
        }
    }
}
