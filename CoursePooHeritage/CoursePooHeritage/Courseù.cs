﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePooHeritage
{
    class Course<T> : ICourse
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
        private void init(List<T> lesParticipants)
        {
            var participant = new List<object>();
            foreach(var meh in lesParticipants)
            {
                LesParticipants.Add(participant);
            }

        }
         
    }
}
