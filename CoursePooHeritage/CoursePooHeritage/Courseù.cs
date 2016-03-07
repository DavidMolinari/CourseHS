using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CoursePooHeritage
{
    public class Course
    {
        private string nomCompetition;
        private DateTime dateCompetition;

        private List<object> lesParticipants;

        public string NomCompetition
        {
            get
            {
                return nomCompetition;
            }

            set
            {
                nomCompetition = value;
            }
        }

        public DateTime DateCompetition
        {
            get
            {
                return dateCompetition;
            }

            set
            {
                dateCompetition = value;
            }
        }

        protected List<object> LesParticipants
        {
            get
            {
                return lesParticipants;
            }

            set
            {
                lesParticipants = value;
            }
        }

        /// <summary>
        ///  Procèdure qui ordonne la collection lesParticipants dans l'ordre de classement WCSL
        ///  TODO
        /// </summary>
        protected void classerLesParticipants(){}


        /// <summary>
        /// L'initialisation d'un participant, j'ai fait de la merde.
        /// </summary>
        /// <param name="lesParticipants"></param>

        public void initTruc()
        {
 
        }
        public void initTruc(string nomCompetition, DateTime dateCompetition, List<object> lesParticipants)
        {
            this.NomCompetition = nomCompetition;
            this.DateCompetition = dateCompetition;
            this.lesParticipants = new List<object>(lesParticipants);
        }

        private void attribuerDossards(int bornInf, int borneSup)
        {
            // histoire de générer un nombre entre Deux nombre, putain obvioussité meh
            Random rnd = new Random();
            // bon ça ne veut pas hériter, meh 
            // J'ai du le mettre en static, histoire de... meh :c
            // borneSup  + 1 parce que la borneSup n'est pas incluse, ou est incluse je sais plus, mais j'dois mettre +1 
            var uneParticipation = new Participation();
            uneParticipation.NumDossard = rnd.Next(bornInf, borneSup + 1);
        }
        private void traitementDossards()
        {
            int nb = lesParticipants.Count;

        } 
    }
}
