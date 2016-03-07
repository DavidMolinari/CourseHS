using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePooHeritage
{
    class Course_Descente : Course
    {
        private int longueur;

        public int Longueur
        {
            get
            {
                return longueur;
            }

            set
            {
                longueur = value;
            }
        }


        public void init(List<object> lesParticipants, int pLong)
        {
            var unParticipantCourseDescente = new Participation(); // meh..
            this.Longueur = pLong;
            
        }


    }
}
