using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePooHeritage
{
    class Competiteur
    {
        private int numeroCompetiteur;
        private string nomCompetiteur;
        private string prenomCompetiteur;
        private int classementFIS;
        private int classementWCSL;

        public int NumeroCompetiteur
        {
            get
            {
                return numeroCompetiteur;
            }

            set
            {
                numeroCompetiteur = value;
            }
        }

        public string NomCompetiteur
        {
            get
            {
                return nomCompetiteur;
            }

            set
            {
                nomCompetiteur = value;
            }
        }

        public string PrenomCompetiteur
        {
            get
            {
                return prenomCompetiteur;
            }

            set
            {
                prenomCompetiteur = value;
            }
        }

        public int ClassementFIS
        {
            get
            {
                return classementFIS;
            }

            set
            {
                classementFIS = value;
            }
        }

        public int ClassementWCSL
        {
            get
            {
                return classementWCSL;
            }

            set
            {
                classementWCSL = value;
            }
        }

        public Competiteur(int numeroCompetiteur, string nomCompetiteur, string prenomCompetiteur, int classementFIS, int classementWCSL)
        {
            this.NumeroCompetiteur = numeroCompetiteur;
            this.NomCompetiteur = nomCompetiteur;
            this.PrenomCompetiteur = prenomCompetiteur;
            this.ClassementFIS = classementFIS;
            this.ClassementWCSL = classementWCSL;
        }
    }


}
