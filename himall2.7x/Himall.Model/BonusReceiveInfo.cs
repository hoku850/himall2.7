//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Himall.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BonusReceiveInfo:BaseModel
    {
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long BonusId { get; set; }
        public string OpenId { get; set; }
        public Nullable<System.DateTime> ReceiveTime { get; set; }
        public decimal Price { get; set; }
        public Nullable<bool> IsShare { get; set; }
        public bool IsTransformedDeposit { get; set; }
        public Nullable<long> UserId { get; set; }
    
        public virtual BonusInfo Himall_Bonus { get; set; }
        public virtual UserMemberInfo Himall_Members { get; set; }
    }
}