//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_System_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reader_Book
    {
        public int member_id { get; set; }
        public int book_id { get; set; }
        public Nullable<int> emp_id { get; set; }
        public System.DateTime issu_Date { get; set; }
        public Nullable<System.DateTime> return_Date { get; set; }
        public Nullable<bool> late { get; set; }
        public Nullable<RequestStatus> status { get; set; }
        public Nullable<System.DateTime> last_updated { get; set; }
        public Nullable<bool> returned { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }
        public int request_id { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
