//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payee
    {
        public Payee()
        {
            this.Payments = new HashSet<Payment>();
        }
    
        public string PayeeID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
