using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePooHeritage
{
    public class Participation
    {
        private static int numDossard;
        private int classement;

        public static int NumDossard
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

        public int Classement
        {
            get
            {
                return classement;
            }

            set
            {
                classement = value;
            }
        }

        public void init()
        {
            this.NumDossard = NumDossard;
            this.Classement = Classement;
        }
    }
}
