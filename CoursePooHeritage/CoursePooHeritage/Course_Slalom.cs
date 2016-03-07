using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePooHeritage
{
    /// <summary>
    /// Chaque objet de cette classe est une course de slalom
    /// </summary>
    public class Course_Slalom : Course
    {
        private void attribuerDossards(int bornInf, int borneSup)
        {

            // histoire de générer un nombre entre Deux nombre, putain obvioussité meh
            Random rnd = new Random();
            // bon ça ne veut pas hériter, meh 
            // J'ai du le mettre en static, histoire de... meh :c
            // borneSup  + 1 parce que la borneSup n'est pas incluse, ou est incluse je sais plus, mais j'dois mettre +1
            Participation.NumDossard = rnd.Next(bornInf, borneSup + 1);
        }
    }
}
