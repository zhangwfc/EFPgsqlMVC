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
    
    public partial class multitaskstreamfilelist
    {
        public int id { get; set; }
        public int streaminfoid { get; set; }
        public int taskid { get; set; }
        public int imsitaskid { get; set; }
        public int subtaskid { get; set; }
        public int commandid { get; set; }
        public string guid { get; set; }
        public string testcommand { get; set; }
    }
}
