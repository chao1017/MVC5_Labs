//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MH_Repository.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class calendar_list
    {
        public string corp_id { get; set; }
        public string calendar_id { get; set; }
        public string calendar_desc { get; set; }
        public string calendar_desc_e { get; set; }
        public string country_code { get; set; }
        public string country_desc { get; set; }
        public int oversea_day { get; set; }
        public string is_default { get; set; }
    }
}