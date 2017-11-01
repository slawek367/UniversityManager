using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            University WSEI = new University("Wyzsza szkola informatyki i ekonometrii");
            WSEI.addNewStudent("Tomasz", "Kowalski", 1111);
            WSEI.addNewStudent("Roman", "Kowalski", 1113);
            WSEI.addNewStudent("Jacek", "Kowalski", 1114);
            WSEI.addNewStudent("Wacek", "Kowalski", 1116);
            WSEI.addNewStudent("Kazek", "Kowalski", 1134);
            WSEI.addNewStudent("Staszek", "Kowalski", 1233);
            WSEI.addNewStudent("Roman", "Kowalski", 1432);

            WSEI.addNewUniversityClass("1A");
            WSEI.addNewUniversityClass("1B");

            WSEI.setStudentClass(1111, "1A");
            WSEI.setStudentClass(1113, "1A");
            WSEI.setStudentClass(1114, "1A");
            WSEI.setStudentClass(1116, "1B");
            WSEI.setStudentClass(1134, "1B");
            WSEI.setStudentClass(1233, "1B");
            WSEI.setStudentClass(1432, "1B");

            WSEI.addNewSubject("Matematyka");
            WSEI.addNewSubject("Javascript");
            WSEI.addNewSubject("Wzorce projektowe");
            WSEI.addNewSubject("Modelowanie procesow biznesowych");
            WSEI.addNewSubject("Angielski");



            UniversityInfo.ShowSubjects(WSEI);
            //WSEI.universityClasses["1A"].classDiary.AddSubjectToDiary("Matematyka");

        }
    }
}
