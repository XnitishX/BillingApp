//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillingApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Inventories = new HashSet<Inventory>();
            this.InvoiceItems = new HashSet<InvoiceItem>();
        }
    
        public int pid { get; set; }
        public string name { get; set; }
        public string weight { get; set; }
        public Nullable<int> tid { get; set; }
        public Nullable<int> mid { get; set; }
        public Nullable<decimal> mrp { get; set; }
        public Nullable<decimal> rate { get; set; }
        public Nullable<decimal> vat { get; set; }
        public Nullable<decimal> discount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Type Type { get; set; }
    }
}
