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
    
    public partial class ChargeDetailInfo:BaseModel
    {
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long MemId { get; set; }
        public Nullable<System.DateTime> ChargeTime { get; set; }
        public decimal ChargeAmount { get; set; }
        public string ChargeWay { get; set; }
        public Model.ChargeDetailInfo.ChargeDetailStatus ChargeStatus { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    }
}
