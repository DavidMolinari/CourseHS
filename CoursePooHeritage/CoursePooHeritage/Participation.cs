using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePooHeritage
{
    class Participation : Course
    {
        private int numDossard;
        private int classement;

        public int NumDossard
        {
            get
            {
                return numDossard;
            }

            set
            {
                numDossard = value;
            }
        }

       

        public void init()
        {
            this.NumDossard = NumDossard;
        }
    }
}
