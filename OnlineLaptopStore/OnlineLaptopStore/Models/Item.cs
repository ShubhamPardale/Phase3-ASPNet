//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineLaptopStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public System.Guid Item_id { get; set; }
        public int Category_id { get; set; }
        public string Item_code { get; set; }
        public string Item_name { get; set; }
        public string Description { get; set; }
        public string Image_path { get; set; }
        public decimal Item_price { get; set; }
    }
}
