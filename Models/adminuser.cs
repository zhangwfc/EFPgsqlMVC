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
    
    public partial class adminuser
    {
        public int id { get; set; }
        public int companyid { get; set; }
        public int type { get; set; }
        public string username { get; set; }
        public string userpassword { get; set; }
        public string realname { get; set; }
        public string sex { get; set; }
        public string mobile { get; set; }
        public int status { get; set; }
        public int createuserid { get; set; }
        public System.DateTime createtime { get; set; }
        public string address { get; set; }
        public string remark { get; set; }
        public int pid { get; set; }
        public int depid { get; set; }
        public string createusername { get; set; }
        public int usertype { get; set; }
    }
}
