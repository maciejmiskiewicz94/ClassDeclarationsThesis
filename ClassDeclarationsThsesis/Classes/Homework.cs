using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDeclarationsThsesis.Classes
{
    public class Homework
    {
        public List<Task> tasklist;
        public int subject_id;
        DateTime deadline;
        public Homework(List<Task> tasklist, int class_id, DateTime deadline)
        {
            this.tasklist = tasklist;
            this.subject_id = class_id;
            this.deadline = deadline;
        }

    }
}