using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class UniversityInfo
    {
        public static void ShowSubjects(University university){
            Console.WriteLine("\nUniwersytet: {0} przedmioty na uczelni:", university.universityName);
            foreach(var sub in university.universitySubjects)
            {
                Console.WriteLine(sub.Key);
            }
        }

        public static void ShowStudents(University university)
        {
            Console.WriteLine("\nUniwersytet: {0} przedmioty na uczelni:", university.universityName);
            foreach (var sub in university.universitySubjects)
            {
                Console.WriteLine(sub.Key);
            }
        }

        public static void ShowAllStudentClassesInfo(University university)
        {
            Console.WriteLine("\nUniwersytet: {0} przedmioty na uczelni:", university.universityName);
            foreach (var sub in university.universitySubjects)
            {
                Console.WriteLine(sub.Key);
            }
        }
    }
}
