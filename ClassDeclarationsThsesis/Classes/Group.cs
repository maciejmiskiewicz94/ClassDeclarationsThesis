using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDeclarationsThsesis.Classes
{
    public class Group
    {
        public int group_id;
        public int subject_id;
        public List<User> students;
        public int teacher_id;
        public Group(int group_id, int subject_id, List<User> students, int teacher_id)
        {
            this.group_id = group_id;
            this.subject_id = subject_id;
            this.students = students;
            this.teacher_id = teacher_id;
        }
    }
}