using ClassDeclarationsThsesis.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDeclarationsThsesis.Models
{
    public class Homework
    {
        public List<Task> tasklist { get; set; }
        public int subject_id { get; set; }
        public DateTime deadline { get; set; }
    }
}