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
    
    public partial class devicestate
    {
        public string deviceid { get; set; }
        public Nullable<int> batterylevel { get; set; }
        public Nullable<long> totalspace { get; set; }
        public Nullable<long> availablespace { get; set; }
        public Nullable<int> rat { get; set; }
        public Nullable<long> statetimestamp { get; set; }
        public int imsitaskid { get; set; }
        public System.DateTimeOffset loctiontimestamptz { get; set; }
        public Nullable<int> usetime { get; set; }
        public Nullable<long> wifidata { get; set; }
        public Nullable<long> mobiledata { get; set; }
        public int istesting { get; set; }
    }
}