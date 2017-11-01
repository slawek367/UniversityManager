using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class StudentClass
    {
        string className { get; set; }
        public Diary classDiary { get; set; }
        List<int> classStudents { get; set; }

        public StudentClass(string className)
        {
            this.className = className;
            classStudents = new List<int>();
        }

        public void addStudentToClass(int studentId)
        {
            classStudents.Add(studentId);
        }
    }
}
