using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDeclarationsThsesis.Models
{
    public class Homework
    {
        public string name { get; set; }
        public int subject_id { get; set; }
        public DateTime deadline { get; set; }
        //public List<Task> tasks { get; set; }
    }
}