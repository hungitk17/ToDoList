//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoList
{
    using System;
    using System.Collections.Generic;
    
    public partial class comment
    {
        public int comment_id { get; set; }
        public string user_id { get; set; }
        public string task_id { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
    
        public virtual task task { get; set; }
        public virtual user user { get; set; }
    }
}
