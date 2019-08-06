//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace storemanagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int Id { get; set; }
        public int empId { get; set; }
        public string deptName { get; set; }
        public Nullable<System.DateTime> approvalDate { get; set; }
        public string remarks { get; set; }
        public string status { get; set; }
        public int qty { get; set; }
        public int productId { get; set; }
        public string productDesc { get; set; }
        public string productCat { get; set; }
        public string empName { get; set; }
        public string empEmail { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
