﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CoursePooHeritage
{
    public class Participation
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
            this.NumDossard = numDossard;
            this.Classement = classement;
        }
    }
}
