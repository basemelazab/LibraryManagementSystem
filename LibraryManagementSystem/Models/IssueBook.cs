//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class IssueBook
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string BookId { get; set; }
        public System.DateTime IssueDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
