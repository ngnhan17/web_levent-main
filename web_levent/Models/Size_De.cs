//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web_levent.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Size_De
    {
        public int Size_Pro { get; set; }
        public int ID_Cate { get; set; }
        public Nullable<int> ID_Details { get; set; }
        public string Size_Name { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Detail Detail { get; set; }
    }
}
