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
    
    public partial class indoorlayer
    {
        public int id { get; set; }
        public string layername { get; set; }
        public Nullable<long> filelength { get; set; }
        public Nullable<long> createdate { get; set; }
        public Nullable<int> createuserid { get; set; }
        public string createusername { get; set; }
        public Nullable<long> modifytime { get; set; }
        public Nullable<int> modifyuserid { get; set; }
        public string modifyusername { get; set; }
        public string address { get; set; }
    }
}