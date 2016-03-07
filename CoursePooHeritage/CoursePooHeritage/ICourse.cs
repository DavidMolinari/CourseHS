using System;

namespace CoursePooHeritage
{
    interface ICourse
    {
        DateTime DateCompetition { get; set; }
        string NomCompetition { get; set; }
    }
}