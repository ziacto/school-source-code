//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceePubCloud
{
    using System;
    using System.Collections.Generic;
    
    public partial class Favourite
    {
        public int id { get; private set; }
    
        public virtual eBook eBook { get; set; }
        public virtual Chapter Chapter { get; set; }
        public virtual User User { get; set; }
    }
}