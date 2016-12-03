using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDeclarationsThsesis.Classes
{
    public class Task
    {
        public int task_id;
        public int subject_id;
        public string name;
        public int value;
        public Task(int task_id, int class_id, string name, int value)
        {
            this.task_id = task_id;
            this.subject_id = class_id;
            this.name = name;
            this.value = value;
        }

    }
}