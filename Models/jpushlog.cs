//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFPgsqlMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class jpushlog
    {
        public int id { get; set; }
        public string username { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> userid { get; set; }
        public string responestate { get; set; }
        public string target { get; set; }
        public string respone { get; set; }
        public string content { get; set; }
    }
}
