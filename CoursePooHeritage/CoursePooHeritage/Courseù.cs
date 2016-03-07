using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePooHeritage
{
    class Course<T>
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

        private void init(Competiteur competiteursParticipants){
            
        }
         
    }
}
