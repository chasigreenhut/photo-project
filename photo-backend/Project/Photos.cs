//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photos
    {
        public int orderId { get; set; }
        public string photoUrl { get; set; }
        public Nullable<bool> selected { get; set; }
    
        public virtual Orders Orders { get; set; }
    }
}
