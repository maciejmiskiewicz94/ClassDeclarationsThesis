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
    
    public partial class Group
    {
        public Group(int id, int i, string modelGroupName, int teacherUserId)
        {
            this.class_id = id;
            this.group_id = i;
            this.name = modelGroupName;
            this.user_id = teacherUserId;
        }

        public int class_id { get; set; }
        public int group_id { get; set; }
        public string name { get; set; }
        public int user_id { get; set; }
    
        public virtual Subject Subject { get; set; }
        public virtual User User { get; set; }
    }
}
