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
    
    public partial class provincialsingletesttime
    {
        public int id { get; set; }
        public string areaid { get; set; }
        public string carrier { get; set; }
        public string mobilemode { get; set; }
        public int testtime { get; set; }
        public System.DateTimeOffset statisticstime { get; set; }
        public System.DateTimeOffset datatime { get; set; }
        public int companyid { get; set; }
    }
}
