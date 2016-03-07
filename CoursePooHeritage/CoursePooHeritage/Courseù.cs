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

        protected List<object> lesParticipants;

        /// <summary>
        ///  Procèdure qui ordonne la collection lesParticipants dans l'ordre de classement WCSL
        ///  TODO
        /// </summary>
        protected void classerLesParticipants(){}
    }
}
