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
    
    public partial class executionstatus
    {
        public int id { get; set; }
        public Nullable<int> subtaskid { get; set; }
        public string name { get; set; }
        public Nullable<int> count { get; set; }
        public Nullable<int> status { get; set; }
        public string filepath { get; set; }
        public string guid { get; set; }
        public Nullable<int> commandid { get; set; }
        public Nullable<int> currenttimes { get; set; }
        public string summary { get; set; }
        public Nullable<long> updatedat { get; set; }
        public Nullable<bool> startconditionreached { get; set; }
        public Nullable<bool> endconditionreached { get; set; }
    }
}
