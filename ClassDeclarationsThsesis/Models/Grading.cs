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
    
    public partial class Grading
    {
        public int user_id { get; set; }
        public int task_id { get; set; }
        public int present { get; set; }
        public Nullable<int> points_for_presence { get; set; }
    
        public virtual Task Task { get; set; }
        public virtual User User { get; set; }
    }
}
