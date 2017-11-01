using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class University
    {
        public string universityName;
        public Dictionary<int, Student> universityStudents;
        public Dictionary<string, StudentClass> universityClasses;
        public Dictionary<string, Subject> universitySubjects;

        public University(string universityName)
        {
            this.universityName = universityName;
            this.universityStudents = new Dictionary<int, Student>();
            this.universityClasses = new Dictionary<string, StudentClass>();
            this.universitySubjects = new Dictionary<string, Subject>();
        }

        public void addNewStudent(string name, string surrname, int id)
        {
            try
            {
                Student student = new Student(name, surrname, id);
                this.universityStudents.Add(id, student);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void addNewUniversityClass(string className)
        {
            try
            {
                StudentClass studentClass = new StudentClass(className);
                this.universityClasses.Add(className, studentClass);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void addNewSubject(string subjectName)
        {
            universitySubjects.Add(subjectName, new Subject(subjectName));
        }

        public void setStudentClass(int studentId, string studentClassName)
        {
            try
            {
                universityClasses[studentClassName].addStudentToClass(studentId);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
