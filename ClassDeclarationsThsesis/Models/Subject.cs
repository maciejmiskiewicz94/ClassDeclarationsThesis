//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassDeclarationsThsesis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        private int v;
        private int userid;

        public Subject(int v, int userid, string name)
        {
            this.class_id = v;
            this.user_id = userid;
            this.name = name;
        }
        public Subject()
        {
        }

        public int class_id { get; set; }
        public int user_id { get; set; }
        public string name { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual Subjects_Users Subjects_Users { get; set; }
        public virtual Task Task { get; set; }
    }
}
