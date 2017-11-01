using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        string name { get; set; }
        string surrname { get; set; }
        int id { get; set; }

        public Student(string name, string surrname, int id)
        {
            this.name = name;
            this.surrname = surrname;
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public string getSurrname()
        {
            return this.surrname;
        }

        public int getId()
        {
            return this.id;
        }
    }
}
