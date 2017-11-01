using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Subject
    {
        string subjectName { get; set; }

        public Subject(string subjectName)
        {
            this.subjectName = subjectName;
        }

        public string getSubjectName()
        {
            return subjectName;
        }
    }
}
