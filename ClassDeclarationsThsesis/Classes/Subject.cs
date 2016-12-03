using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDeclarationsThsesis.Classes
{
    public class Subject
    {
        public int subject_id;
        public string name;
        public int headteacher_id;
        public List<User> teachers;
        public List<User> students;
        public Subject(int subject_id, string name, int headteacher_id, List<User> teachers, List<User> students) 
        {
            this.subject_id = subject_id;
            this.name = name;
            this.headteacher_id = headteacher_id;
            this.teachers = teachers;
            this.students = students;
        }

        public Subject()
        {
        }
    }
}