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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Reader_Book = new HashSet<Reader_Book>();
            this.Reader_Book1 = new HashSet<Reader_Book>();
            this.Borrwed_Book = new HashSet<Borrwed_Book>();
            this.Borrwed_Book1 = new HashSet<Borrwed_Book>();
            this.UserFullName = new FullName();
        }
    
        public int user_id { get; set; }
        public string address { get; set; }
        public Nullable<int> phone { get; set; }
        public Nullable<decimal> salary { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public Nullable<System.DateTime> hiredate { get; set; }
        public string profile_img { get; set; }
        public Nullable<UserType> user_type { get; set; }
        public string email { get; set; }
        public Nullable<UserStatus> user_status { get; set; }
        public Nullable<bool> user_FirstLogin { get; set; }
        public string password { get; set; }
        public Nullable<int> member_super { get; set; }
    
        public FullName UserFullName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reader_Book> Reader_Book { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reader_Book> Reader_Book1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Borrwed_Book> Borrwed_Book { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Borrwed_Book> Borrwed_Book1 { get; set; }
    }
}
