//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Token
    {
        public int TokenId { get; set; }
        public string TokenKey { get; set; }
        public System.DateTime Create { get; set; }
        public Nullable<System.DateTime> Expire { get; set; }
        public Nullable<int> UserId { get; set; }
    }
}
