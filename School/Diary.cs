using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Diary
    {

        Dictionary<Subject, Dictionary<int, Rating>> diary { get; set; }

        public Diary()
        {
            diary = new Dictionary<Subject, Dictionary<int, Rating>>();
        }

        public void AddSubjectToDiary(Subject subject)
        {
            diary.Add(subject, new Dictionary<int, Rating>());
        }

        public void AddStudentToSubject(int studentId, Subject subject)
        {
            diary[subject].Add(studentId, new Rating());
        }

        public void AddRatingToStudentSubject(int rate, int studentId, Subject subject)
        {
            diary[subject][studentId].addRating(rate);
        }
    }
}
